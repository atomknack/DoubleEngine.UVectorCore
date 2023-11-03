//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _Vector_Specific.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

namespace DoubleEngine
{

    public readonly partial struct Vec4D
    {
        public static double AngleDegrees(Vec4D from, Vec4D to) =>
            MathU.RadiansToDegrees(AngleRadians(from, to));
        public static double AngleRadians(Vec4D from, Vec4D to) =>
            Math.Acos(Math.Clamp(Dot(from.Normalized(), to.Normalized()), -1d, 1d));

        public static Vec4D Round(Vec4D v, int rounding = 8) =>
            new Vec4D( MathU.Round(v.x, rounding), MathU.Round(v.y, rounding), MathU.Round(v.z, rounding), MathU.Round(v.w, rounding) );
        public static Vec4D RadiansToDegrees(Vec4D v) => 
            new Vec4D( MathU.RadiansToDegrees(v.x), MathU.RadiansToDegrees(v.y), MathU.RadiansToDegrees(v.z), MathU.RadiansToDegrees(v.w) );
        public static Vec4D DegreesTo360PositiveDegrees(Vec4D v) =>
            new Vec4D( MathU.DegreesTo360PositiveDegrees(v.x), MathU.DegreesTo360PositiveDegrees(v.y), MathU.DegreesTo360PositiveDegrees(v.z), MathU.DegreesTo360PositiveDegrees(v.w) );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec4D Max(in Vec4D a, in Vec4D rhs) => 
            new Vec4D ( Math.Max(a.x, rhs.x), Math.Max(a.y, rhs.y), Math.Max(a.z, rhs.z), Math.Max(a.w, rhs.w) );
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec4D Min(in Vec4D a, in Vec4D rhs) => 
            new Vec4D ( Math.Min(a.x, rhs.x), Math.Min(a.y, rhs.y), Math.Min(a.z, rhs.z), Math.Min(a.w, rhs.w) );
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public readonly double MagnitudeManhattan() => Math.Abs(x) + Math.Abs(y) + Math.Abs(z) + Math.Abs(w);//MathU.Abs(x) + MathU.Abs(y) + MathU.Abs(z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public readonly double DistanceSqr( Vec4D b) => (this - b).MagnitudeSqr();
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public readonly double Distance(Vec4D b) => (this - b).Magnitude();
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public readonly double DistanceManhattan(Vec4D b) => (this - b).MagnitudeManhattan();
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public readonly bool CloseByEach(Vec4D b, double epsilon = 1E-5d ) =>
            Math.Abs(x - b.x) < epsilon && Math.Abs(y - b.y) < epsilon && Math.Abs(z - b.z) < epsilon && Math.Abs(w - b.w) < epsilon;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public readonly bool CloseBySqrDistance(Vec4D b, double sqrEpsilon = 1E-9d ) => DistanceSqr(this, b) <= sqrEpsilon;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public readonly bool CloseByDistance( Vec4D b, double epsilon = 1E-5d ) => Distance(this, b) <= epsilon;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool CloseByManhattan( Vec4D b, double epsilon = 1E-5d ) =>
            CloseByManhattan(this, b, epsilon);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static double DistanceSqr(Vec4D a, Vec4D b) => (a - b).MagnitudeSqr();
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static double Distance(Vec4D a, Vec4D b) => (a - b).Magnitude();
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static double DistanceManhattan(Vec4D a, Vec4D b) => (a - b).MagnitudeManhattan();
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static bool CloseByEach(Vec4D a, Vec4D b, double epsilon = 1E-5d ) =>
            Math.Abs(a.x - b.x) < epsilon && Math.Abs(a.y - b.y) < epsilon && Math.Abs(a.z - b.z) < epsilon && Math.Abs(a.w - b.w) < epsilon;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static bool CloseBySqrDistance(Vec4D a, Vec4D b, double sqrEpsilon = 1E-9d ) => DistanceSqr(a, b) <= sqrEpsilon;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static bool CloseByDistance(Vec4D a, Vec4D b, double epsilon = 1E-5d ) => Distance(a, b) <= epsilon;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CloseByManhattan(Vec4D a, Vec4D b, double epsilon = 1E-5d )
        {
            double d = Math.Abs(a.x - b.x);
            if (d > epsilon)
                return false;
            d += Math.Abs(a.y - b.y);
            if (d > epsilon)
                return false;
            d += Math.Abs(a.z - b.z);
            if (d > epsilon)
                return false;
            d += Math.Abs(a.w - b.w);
            if (d > epsilon)
                return false;
            return true;
        }


        public static Vec4D Project(in Vec4D vector, in Vec4D onNormal)
        {
            double onNormalSqrMagnitude = onNormal.MagnitudeSqr();
            if (onNormalSqrMagnitude < 1e-15d)
                return zero;
            double offset = Dot(vector, onNormal) / onNormalSqrMagnitude;
            return onNormal.Multiplied(offset);
        }


    }
}