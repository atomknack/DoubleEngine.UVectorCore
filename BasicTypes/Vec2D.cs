using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
    
namespace VectorCore
{
    public readonly partial struct Vec2D
    {
        public readonly static Vec2D zero = new Vec2D(0d, 0d);
        public readonly static Vec2D one = new Vec2D(1d, 1d);
        public readonly static Vec2D identity = zero;

        public bool IsZeroish(double epsilon = 1e-12d) =>
            MagnitudeSqr() <= epsilon;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec2D NormalFromLineSegment(in Vec2D fromPoint, in Vec2D toPoint) => //need testing
            (toPoint - fromPoint).Normalized();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Cross(Vec2D a, Vec2D rhs) => a.x * rhs.y - a.y * rhs.x;


        //public static Vec2D Rotate(Vec2D v, double degrees) => RotateClockwise(v, degrees);
        public static Vec2D RotateClockwise(Vec2D v, double degrees) => RotateRadiansClockwise(v, MathU.DegreesToRadians(degrees));
        public static Vec2D RotateRadiansClockwise(Vec2D v, double radians)
        {
            double c = Math.Cos(radians); 
            double s = Math.Sin(radians);
            return new Vec2D(c * v.x - s * v.y, s * v.x + c * v.y);
        }
        public static Vec2D RotateCounterClockwise(Vec2D v, double degrees) 
            => RotateRadiansCounterClockwise(v, MathU.DegreesToRadians(degrees));
        public static Vec2D RotateRadiansCounterClockwise(Vec2D v, double radians)
            => RotateRadiansClockwise(v, -radians);

        /*public static Vec2D Rotate(Vec2D v, double radianAngle)
{
    radianAngle = -radianAngle;
    return new Vec2D(
        v.x * Math.Cos(radianAngle) - v.y * Math.Sin(radianAngle),
        v.x * Math.Sin(radianAngle) + v.y * Math.Cos(radianAngle)
    );
}*/
    }
}
