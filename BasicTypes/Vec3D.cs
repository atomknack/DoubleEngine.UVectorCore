using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace VectorCore
{
    public readonly partial struct Vec3D
    {
        public readonly static Vec3D zero =     new Vec3D(0, 0, 0);
        public readonly static Vec3D one =      new Vec3D(1, 1, 1);
        public readonly static Vec3D forward =  new Vec3D(0, 0, 1);
        public readonly static Vec3D up =       new Vec3D(0, 1, 0);
        public readonly static Vec3D right =    new Vec3D(1, 0, 0);
        public readonly static Vec3D back =     new Vec3D(0, 0, -1);
        public readonly static Vec3D down =     new Vec3D(0, -1, 0);
        public readonly static Vec3D left =     new Vec3D(-1, 0, 0);
        public readonly static Vec3D identity = zero;
        public readonly static Vec3D scaleIdentity = one;

        /*
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly Vec3D Translated(Vec3D vector) => AddedVect(vector);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly Vec3D Scaled(Vec3D vector) => MultipliedVect(vector);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public readonly Vec3D Rotated(QuaternionD rotation) => rotation.Rotate(this);
        */

        public bool IsZeroish(double epsilon = 1e-12d) =>
            MagnitudeSqr() <= epsilon;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec3D NormalFromTriangle(in Vec3D a, in Vec3D b, in Vec3D c) => 
            Cross(b - a, c - a).Normalized();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec3D NormalFromLineSegment(in Vec3D fromPoint, in Vec3D toPoint) => //need testing
            (toPoint - fromPoint).Normalized();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec3D Cross(in Vec3D lhs, in Vec3D rhs) =>
            new Vec3D(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
        

        //public Vec3D(double x = 0f, double y = 0f, double z = 0f) : this((double)x, (double)y, (double)z) { }




        /*[MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Angle(Vec3D from, Vec3D to)
        {
            double num = Math.Sqrt(from.SqrMagnitude * to.SqrMagnitude);
            if (num < 1E-15f)
                return 0d;
            double num2 = Math.Clamp(Vec3D.Dot(from, to) / num, -1f, 1f);
            return Math.Acos(num2) * 57.29578f;
        }*/

        /*[MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vec3D ClampedByMagnitude(double maxLength) //P
        {
            double sqrMagnitude = SqrMagnitude();
            if (maxLength * maxLength >= sqrMagnitude)
                return this;
            if (sqrMagnitude <= 0.00000000001d) // test by Vec3D(0,0,0)
                return this;
            double magnitude = Math.Sqrt(sqrMagnitude);
            return DividedBy(magnitude).Scaled(maxLength);
            //return new Vec3D((x / magnitude) * maxLength, (y / magnitude) * maxLength, (z / magnitude) * maxLength);
        }*/




    }

}