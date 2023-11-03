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

public readonly partial struct Vec2I : IFormattable
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int MagnitudeSqr()
    {
         return x * x + y * y;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Dot(in Vec2I a, in Vec2I b)
    {
        return a.x * b.x + a.y * b.y;
    }

    public readonly override string ToString() => 
            $"({CommonHelpers.ToStringWithDot(x, "F2")}, {CommonHelpers.ToStringWithDot(y, "F2")})";
    public readonly string ToString(string format) => 
            $"({CommonHelpers.ToStringWithDot(x, format)}, {CommonHelpers.ToStringWithDot(y, format)})";
    public readonly string ToString(string format, IFormatProvider formatProvider) => 
            $"({CommonHelpers.ToStringWithDot(x, format, formatProvider)}, {CommonHelpers.ToStringWithDot(y, format, formatProvider)})";


}

}