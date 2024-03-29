//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _VectorLike_Constructor_Json.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace VectorCore
{
    public readonly partial struct Vec3short : IFormattable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int MagnitudeSqr()
        {
            return x * x + y * y + z * z;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Dot(in Vec3short a, in Vec3short b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        public readonly override string ToString() =>
                $"({CommonHelpers.ToStringWithDot(x, "F2")}, {CommonHelpers.ToStringWithDot(y, "F2")}, {CommonHelpers.ToStringWithDot(z, "F2")})";
        public readonly string ToString(string format) =>
                $"({CommonHelpers.ToStringWithDot(x, format)}, {CommonHelpers.ToStringWithDot(y, format)}, {CommonHelpers.ToStringWithDot(z, format)})";
        public readonly string ToString(string format, IFormatProvider formatProvider) =>
                $"({CommonHelpers.ToStringWithDot(x, format, formatProvider)}, {CommonHelpers.ToStringWithDot(y, format, formatProvider)}, {CommonHelpers.ToStringWithDot(z, format, formatProvider)})";


    }
}

