//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _Vector_Lerps.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

namespace VectorCore
{

public readonly partial struct Vec2D
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D Lerp(Vec2D from, Vec2D to, double amount) =>
            LerpUnclamped(from, to, Math.Clamp(amount, 0d, 1d));
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D LerpUnclamped(Vec2D from, Vec2D to, double amount)
    {
         return (from*(1d-amount))+(to*amount);
    }
}

}
