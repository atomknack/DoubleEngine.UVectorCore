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

public readonly partial struct Vec3F
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F operator +(in Vec3F vector, float scalar) => new Vec3F ( vector.x + scalar, vector.y + scalar, vector.z + scalar );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F operator -(in Vec3F vector) => new Vec3F ( -vector.x, -vector.y, -vector.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F operator -(in Vec3F vector, float scalar) => new Vec3F ( vector.x - scalar, vector.y - scalar, vector.z - scalar );

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F operator *(in Vec3F vector, float scalar) => new Vec3F ( vector.x * scalar, vector.y * scalar, vector.z * scalar );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F Multiply(in Vec3F vector, float scalar) => new Vec3F ( vector.x * scalar, vector.y * scalar, vector.z * scalar );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3F Multiplied(float scalar) => new Vec3F ( x * scalar, y * scalar, z * scalar );
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F operator /(in Vec3F vector, float scalarDivider) => new Vec3F ( vector.x / scalarDivider, vector.y / scalarDivider, vector.z / scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F Divide(in Vec3F vector, float scalarDivider) => new Vec3F ( vector.x / scalarDivider, vector.y / scalarDivider, vector.z / scalarDivider );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3F DividedBy(float divider) => new Vec3F ( x / divider, y / divider, z / divider );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F operator %(in Vec3F vector, float scalarDivider) => new Vec3F ( vector.x % scalarDivider, vector.y % scalarDivider, vector.z % scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F RemainderOfDivision(in Vec3F vector, float scalarDivider) => new Vec3F ( vector.x % scalarDivider, vector.y % scalarDivider, vector.z % scalarDivider );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3F RemainderOfDivision(float divider) => new Vec3F ( x % divider, y % divider, z % divider );

    /*
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F operator +(in Vec3F lhs, in Vec3F r) => new Vec3F ( lhs.x + r.x, lhs.y + r.y, lhs.z + r.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F AddVect(in Vec3F lhs, in Vec3F r) => new Vec3F ( lhs.x + r.x, lhs.y + r.y, lhs.z + r.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3F AddedVect(in Vec3F vector) => new Vec3F ( x + vector.x, y + vector.y, z + vector.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F operator -(in Vec3F lhs, in Vec3F r) => new Vec3F ( lhs.x - r.x, lhs.y - r.y, lhs.z - r.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F MultiplyVect(in Vec3F lhs, in Vec3F r) => new Vec3F ( lhs.x * r.x, lhs.y * r.y, lhs.z * r.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3F MultipliedVect(in Vec3F vector) => new Vec3F ( x * vector.x, y * vector.y, z * vector.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F DivideVect(in Vec3F vector, in Vec3F divider) => new Vec3F ( vector.x / divider.x, vector.y / divider.y, vector.z / divider.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3F DividedByVect(in Vec3F divider) => new Vec3F ( x / divider.x, y / divider.y, z / divider.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3F RemainderOfDivisionVect(in Vec3F vector, in Vec3F divider) => new Vec3F ( vector.x % divider.x, vector.y % divider.y, vector.z % divider.z );
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3F RemainderOfDivisionVect(in Vec3F divider) => new Vec3F ( x % divider.x, y % divider.y, z % divider.z );
    */
}

}
