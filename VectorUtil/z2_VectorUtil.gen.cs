﻿//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DoubleEngine
{
    public static partial class VectorUtil
    {

        private const float E_D = MathU.EPSILON2_6;
        private const float E_SQR = MathU.EPSILON1_7; //not 1_8, because we need to negate rounding errors threshold


    /* 
    /////////////////
    ///////////////refactored, moved to VectorArray_LookUpMethods
    /////////////////

    public static int CloseWithLowerIndexOrSelf(this Vector3[] vertices, int vertexIndex, float epsilon = E_D)
    {
        Vector3 vertex= vertices[vertexIndex];
        for (var i = 0; i < vertexIndex; i++)
            if (vertex.CloseByEach(vertices[i], epsilon))
                return i;
        return vertexIndex;
    }

    [Obsolete("its not closest, its first close enought or return lookUpTo")]
    public static int ClosestOrLast(this Vector3[] vertices, Vector3 vertex, int lookUpTo, float epsilon = E_D)
    {
        for (var i = 0; i < lookUpTo; i++)
            if (vertex.CloseByEach(vertices[i], epsilon))
                return i;
        return lookUpTo;
    }
    */

    /*
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Scaled(this Vector3 v, Vector3 b)=> new Vector3(v.x * b.x, v.y * b.y, v.z * b.z);
    public static Vector3? Scaled(this Vector3? v, Vector3 b) => v == null ? b : v.Value.Scaled(b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Rotated(this Vector3 v, Quaternion rotation) => rotation * v;

    public static Quaternion Rotated(this Quaternion from, Quaternion rotation) => from * rotation;
    public static Quaternion? Rotated(this Quaternion? from, Quaternion rotation) => from == null ? rotation : from.Value.Rotated(rotation);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Translated(this Vector3 v, Vector3 translation) => v + translation;
    public static Vector3? Translated(this Vector3? v, Vector3 translation) => v == null ? translation : v.Value.Translated(translation);
    */

    /*
    public static Vector3 CalcNormal(Vector3 a, Vector3 b, Vector3 c) => CalcNotNormalizedNormal(a, b, c).normalized;
    public static Vector3 CalcNotNormalizedNormal(Vector3 a, Vector3 b, Vector3 c)
    {
        Vector3 side1 = b - a;
        Vector3 side2 = c - a;
        return Vector3.Cross(side1, side2);
    }
    */


/*

    /// <summary>Compare 2 equal sized arrays by each vector component</summary>
    /// <exception cref="System.ArgumentNullException">To compare 2 vector array both of them should be not null</exception>
    /// <exception cref="System.ArgumentException">Must compare 2 equal size vector array</exception>
    public static bool NotContainsDifferent(this Vec2D[] a, Vec2D[] b, double epsilon = 1E-5d)
    {
        if (a == null || b == null) throw new ArgumentNullException("To compare 2 vector array both of them should be not null");
        //if (a.Length != b.Length) throw new ArgumentException("Must compare 2 equal size vector array");
        int minSize = Math.Min(a.Length, b.Length);
        for (var i = 0; i < minSize; i++)
        {
            if (a.NotContainsVertex_CloseByEach(b[i], epsilon) || b.NotContainsVertex_CloseByEach(a[i], epsilon))
                return false;
        }
        if (a.Length<b.Length)
            {
                for (var i = minSize; i < b.Length; i++)
                    if (a.NotContainsVertex_CloseByEach(b[i], epsilon))
                        return false;
            }
        else
            {
                for (var i = minSize; i < a.Length; i++)
                    if (b.NotContainsVertex_CloseByEach(a[i], epsilon))
                        return false;
            }
        return true;
    }
    */

/*

    /// <summary>Compare 2 equal sized arrays by each vector component</summary>
    /// <exception cref="System.ArgumentNullException">To compare 2 vector array both of them should be not null</exception>
    /// <exception cref="System.ArgumentException">Must compare 2 equal size vector array</exception>
    public static bool NotContainsDifferent(this Vec3D[] a, Vec3D[] b, double epsilon = 1E-5d)
    {
        if (a == null || b == null) throw new ArgumentNullException("To compare 2 vector array both of them should be not null");
        //if (a.Length != b.Length) throw new ArgumentException("Must compare 2 equal size vector array");
        int minSize = Math.Min(a.Length, b.Length);
        for (var i = 0; i < minSize; i++)
        {
            if (a.NotContainsVertex_CloseByEach(b[i], epsilon) || b.NotContainsVertex_CloseByEach(a[i], epsilon))
                return false;
        }
        if (a.Length<b.Length)
            {
                for (var i = minSize; i < b.Length; i++)
                    if (a.NotContainsVertex_CloseByEach(b[i], epsilon))
                        return false;
            }
        else
            {
                for (var i = minSize; i < a.Length; i++)
                    if (b.NotContainsVertex_CloseByEach(a[i], epsilon))
                        return false;
            }
        return true;
    }
    */

/*

    /// <summary>Compare 2 equal sized arrays by each vector component</summary>
    /// <exception cref="System.ArgumentNullException">To compare 2 vector array both of them should be not null</exception>
    /// <exception cref="System.ArgumentException">Must compare 2 equal size vector array</exception>
    public static bool NotContainsDifferent(this Vec4D[] a, Vec4D[] b, double epsilon = 1E-5d)
    {
        if (a == null || b == null) throw new ArgumentNullException("To compare 2 vector array both of them should be not null");
        //if (a.Length != b.Length) throw new ArgumentException("Must compare 2 equal size vector array");
        int minSize = Math.Min(a.Length, b.Length);
        for (var i = 0; i < minSize; i++)
        {
            if (a.NotContainsVertex_CloseByEach(b[i], epsilon) || b.NotContainsVertex_CloseByEach(a[i], epsilon))
                return false;
        }
        if (a.Length<b.Length)
            {
                for (var i = minSize; i < b.Length; i++)
                    if (a.NotContainsVertex_CloseByEach(b[i], epsilon))
                        return false;
            }
        else
            {
                for (var i = minSize; i < a.Length; i++)
                    if (b.NotContainsVertex_CloseByEach(a[i], epsilon))
                        return false;
            }
        return true;
    }
    */
    }
}