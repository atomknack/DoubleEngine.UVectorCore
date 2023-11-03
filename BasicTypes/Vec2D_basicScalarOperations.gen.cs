//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _VectorLike_basicScalarOperations.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

namespace DoubleEngine
{

public readonly partial struct Vec2D
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D operator +(in Vec2D vector, double scalar) => new Vec2D ( vector.x + scalar, vector.y + scalar );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D operator -(in Vec2D vector) => new Vec2D ( -vector.x, -vector.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D operator -(in Vec2D vector, double scalar) => new Vec2D ( vector.x - scalar, vector.y - scalar );

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D operator *(in Vec2D vector, double scalar) => new Vec2D ( vector.x * scalar, vector.y * scalar );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D Multiply(in Vec2D vector, double scalar) => new Vec2D ( vector.x * scalar, vector.y * scalar );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2D Multiplied(double scalar) => new Vec2D ( x * scalar, y * scalar );
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D operator /(in Vec2D vector, double scalarDivider) => new Vec2D ( vector.x / scalarDivider, vector.y / scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D Divide(in Vec2D vector, double scalarDivider) => new Vec2D ( vector.x / scalarDivider, vector.y / scalarDivider );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2D DividedBy(double divider) => new Vec2D ( x / divider, y / divider );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D operator %(in Vec2D vector, double scalarDivider) => new Vec2D ( vector.x % scalarDivider, vector.y % scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D RemainderOfDivision(in Vec2D vector, double scalarDivider) => new Vec2D ( vector.x % scalarDivider, vector.y % scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2D RemainderOfDivision(double divider) => new Vec2D ( x % divider, y % divider );

    /*
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D operator +(in Vec2D lhs, in Vec2D r) => new Vec2D ( lhs.x + r.x, lhs.y + r.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D AddVect(in Vec2D lhs, in Vec2D r) => new Vec2D ( lhs.x + r.x, lhs.y + r.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2D AddedVect(in Vec2D vector) => new Vec2D ( x + vector.x, y + vector.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D operator -(in Vec2D lhs, in Vec2D r) => new Vec2D ( lhs.x - r.x, lhs.y - r.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D MultiplyVect(in Vec2D lhs, in Vec2D r) => new Vec2D ( lhs.x * r.x, lhs.y * r.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2D MultipliedVect(in Vec2D vector) => new Vec2D ( x * vector.x, y * vector.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D DivideVect(in Vec2D vector, in Vec2D divider) => new Vec2D ( vector.x / divider.x, vector.y / divider.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2D DividedByVect(in Vec2D divider) => new Vec2D ( x / divider.x, y / divider.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2D RemainderOfDivisionVect(in Vec2D vector, in Vec2D divider) => new Vec2D ( vector.x % divider.x, vector.y % divider.y );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec2D RemainderOfDivisionVect(in Vec2D divider) => new Vec2D ( x % divider.x, y % divider.y );
    */
}

}
