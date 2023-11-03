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

public readonly partial struct Vec3I
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I operator +(in Vec3I vector, int scalar) => new Vec3I ( vector.x + scalar, vector.y + scalar, vector.z + scalar );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I operator -(in Vec3I vector) => new Vec3I ( -vector.x, -vector.y, -vector.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I operator -(in Vec3I vector, int scalar) => new Vec3I ( vector.x - scalar, vector.y - scalar, vector.z - scalar );

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I operator *(in Vec3I vector, int scalar) => new Vec3I ( vector.x * scalar, vector.y * scalar, vector.z * scalar );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I Multiply(in Vec3I vector, int scalar) => new Vec3I ( vector.x * scalar, vector.y * scalar, vector.z * scalar );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3I Multiplied(int scalar) => new Vec3I ( x * scalar, y * scalar, z * scalar );
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I operator /(in Vec3I vector, int scalarDivider) => new Vec3I ( vector.x / scalarDivider, vector.y / scalarDivider, vector.z / scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I Divide(in Vec3I vector, int scalarDivider) => new Vec3I ( vector.x / scalarDivider, vector.y / scalarDivider, vector.z / scalarDivider );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3I DividedBy(int divider) => new Vec3I ( x / divider, y / divider, z / divider );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I operator %(in Vec3I vector, int scalarDivider) => new Vec3I ( vector.x % scalarDivider, vector.y % scalarDivider, vector.z % scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I RemainderOfDivision(in Vec3I vector, int scalarDivider) => new Vec3I ( vector.x % scalarDivider, vector.y % scalarDivider, vector.z % scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3I RemainderOfDivision(int divider) => new Vec3I ( x % divider, y % divider, z % divider );

    /*
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I operator +(in Vec3I lhs, in Vec3I r) => new Vec3I ( lhs.x + r.x, lhs.y + r.y, lhs.z + r.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I AddVect(in Vec3I lhs, in Vec3I r) => new Vec3I ( lhs.x + r.x, lhs.y + r.y, lhs.z + r.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3I AddedVect(in Vec3I vector) => new Vec3I ( x + vector.x, y + vector.y, z + vector.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I operator -(in Vec3I lhs, in Vec3I r) => new Vec3I ( lhs.x - r.x, lhs.y - r.y, lhs.z - r.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I MultiplyVect(in Vec3I lhs, in Vec3I r) => new Vec3I ( lhs.x * r.x, lhs.y * r.y, lhs.z * r.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3I MultipliedVect(in Vec3I vector) => new Vec3I ( x * vector.x, y * vector.y, z * vector.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I DivideVect(in Vec3I vector, in Vec3I divider) => new Vec3I ( vector.x / divider.x, vector.y / divider.y, vector.z / divider.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3I DividedByVect(in Vec3I divider) => new Vec3I ( x / divider.x, y / divider.y, z / divider.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3I RemainderOfDivisionVect(in Vec3I vector, in Vec3I divider) => new Vec3I ( vector.x % divider.x, vector.y % divider.y, vector.z % divider.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3I RemainderOfDivisionVect(in Vec3I divider) => new Vec3I ( x % divider.x, y % divider.y, z % divider.z );
    */
}

}