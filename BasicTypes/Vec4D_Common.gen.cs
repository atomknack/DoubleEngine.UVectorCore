//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _VectorLike_Common.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

namespace DoubleEngine
{

public readonly partial struct Vec4D : IFormattable
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly double MagnitudeSqr()
    {
         return x * x + y * y + z * z + w * w;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Dot(in Vec4D a, in Vec4D b)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
    }

    public readonly override string ToString() => 
            $"({CommonHelpers.ToStringWithDot(x, "F2")}, {CommonHelpers.ToStringWithDot(y, "F2")}, {CommonHelpers.ToStringWithDot(z, "F2")}, {CommonHelpers.ToStringWithDot(w, "F2")})";
    public readonly string ToString(string format) => 
            $"({CommonHelpers.ToStringWithDot(x, format)}, {CommonHelpers.ToStringWithDot(y, format)}, {CommonHelpers.ToStringWithDot(z, format)}, {CommonHelpers.ToStringWithDot(w, format)})";
    public readonly string ToString(string format, IFormatProvider formatProvider) => 
            $"({CommonHelpers.ToStringWithDot(x, format, formatProvider)}, {CommonHelpers.ToStringWithDot(y, format, formatProvider)}, {CommonHelpers.ToStringWithDot(z, format, formatProvider)}, {CommonHelpers.ToStringWithDot(w, format, formatProvider)})";


}

}
