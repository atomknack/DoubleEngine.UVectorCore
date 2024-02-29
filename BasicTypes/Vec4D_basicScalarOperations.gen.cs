//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _VectorLike_basicScalarOperations.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

namespace VectorCore
{

public readonly partial struct Vec4D
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D operator +(in Vec4D vector, double scalar) => new Vec4D ( vector.x + scalar, vector.y + scalar, vector.z + scalar, vector.w + scalar );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D operator -(in Vec4D vector) => new Vec4D ( -vector.x, -vector.y, -vector.z, -vector.w );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D operator -(in Vec4D vector, double scalar) => new Vec4D ( vector.x - scalar, vector.y - scalar, vector.z - scalar, vector.w - scalar );

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D operator *(in Vec4D vector, double scalar) => new Vec4D ( vector.x * scalar, vector.y * scalar, vector.z * scalar, vector.w * scalar );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D Multiply(in Vec4D vector, double scalar) => new Vec4D ( vector.x * scalar, vector.y * scalar, vector.z * scalar, vector.w * scalar );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec4D Multiplied(double scalar) => new Vec4D ( x * scalar, y * scalar, z * scalar, w * scalar );
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D operator /(in Vec4D vector, double scalarDivider) => new Vec4D ( vector.x / scalarDivider, vector.y / scalarDivider, vector.z / scalarDivider, vector.w / scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D Divide(in Vec4D vector, double scalarDivider) => new Vec4D ( vector.x / scalarDivider, vector.y / scalarDivider, vector.z / scalarDivider, vector.w / scalarDivider );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec4D DividedBy(double divider) => new Vec4D ( x / divider, y / divider, z / divider, w / divider );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D operator %(in Vec4D vector, double scalarDivider) => new Vec4D ( vector.x % scalarDivider, vector.y % scalarDivider, vector.z % scalarDivider, vector.w % scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D RemainderOfDivision(in Vec4D vector, double scalarDivider) => new Vec4D ( vector.x % scalarDivider, vector.y % scalarDivider, vector.z % scalarDivider, vector.w % scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec4D RemainderOfDivision(double divider) => new Vec4D ( x % divider, y % divider, z % divider, w % divider );

    /*
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D operator +(in Vec4D lhs, in Vec4D r) => new Vec4D ( lhs.x + r.x, lhs.y + r.y, lhs.z + r.z, lhs.w + r.w );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D AddVect(in Vec4D lhs, in Vec4D r) => new Vec4D ( lhs.x + r.x, lhs.y + r.y, lhs.z + r.z, lhs.w + r.w );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec4D AddedVect(in Vec4D vector) => new Vec4D ( x + vector.x, y + vector.y, z + vector.z, w + vector.w );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D operator -(in Vec4D lhs, in Vec4D r) => new Vec4D ( lhs.x - r.x, lhs.y - r.y, lhs.z - r.z, lhs.w - r.w );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D MultiplyVect(in Vec4D lhs, in Vec4D r) => new Vec4D ( lhs.x * r.x, lhs.y * r.y, lhs.z * r.z, lhs.w * r.w );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec4D MultipliedVect(in Vec4D vector) => new Vec4D ( x * vector.x, y * vector.y, z * vector.z, w * vector.w );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D DivideVect(in Vec4D vector, in Vec4D divider) => new Vec4D ( vector.x / divider.x, vector.y / divider.y, vector.z / divider.z, vector.w / divider.w );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec4D DividedByVect(in Vec4D divider) => new Vec4D ( x / divider.x, y / divider.y, z / divider.z, w / divider.w );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4D RemainderOfDivisionVect(in Vec4D vector, in Vec4D divider) => new Vec4D ( vector.x % divider.x, vector.y % divider.y, vector.z % divider.z, vector.w % divider.w );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec4D RemainderOfDivisionVect(in Vec4D divider) => new Vec4D ( x % divider.x, y % divider.y, z % divider.z, w % divider.w );
    */
}

}
