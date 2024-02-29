//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _VectorLike_basicVectOperations.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

namespace VectorCore
{

public readonly partial struct Vec2I
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2I operator +(in Vec2I lhs, in Vec2I r) => new Vec2I ( lhs.x + r.x, lhs.y + r.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2I AddVect(in Vec2I lhs, in Vec2I r) => new Vec2I ( lhs.x + r.x, lhs.y + r.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2I AddedVect(in Vec2I vector) => new Vec2I ( x + vector.x, y + vector.y );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2I operator -(in Vec2I lhs, in Vec2I r) => new Vec2I ( lhs.x - r.x, lhs.y - r.y );
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2I MultiplyVect(in Vec2I lhs, in Vec2I r) => new Vec2I ( lhs.x * r.x, lhs.y * r.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2I MultipliedVect(in Vec2I vector) => new Vec2I ( x * vector.x, y * vector.y );
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2I DivideVect(in Vec2I vector, in Vec2I divider) => new Vec2I ( vector.x / divider.x, vector.y / divider.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2I DividedByVect(in Vec2I divider) => new Vec2I ( x / divider.x, y / divider.y );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2I RemainderOfDivisionVect(in Vec2I vector, in Vec2I divider) => new Vec2I ( vector.x % divider.x, vector.y % divider.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2I RemainderOfDivisionVect(in Vec2I divider) => new Vec2I ( x % divider.x, y % divider.y );

}

}
