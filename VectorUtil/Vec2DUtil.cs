using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//using static MeshUtil;

namespace VectorCore;



public static partial class Vec2DUtil
{

public static int IndexMinXWhereMinY(ROSpanVec2D v, int a, int b)
{
    if (v[b].y < v[a].y)
        return b;
    if (v[b].y == v[a].y && v[b].x < v[a].x)
        return b;
    return a;
}
public static int MinXWhereMinY(this ROSpanVec2D v)
{
    int result = 0;
    for (int i = 1; i < v.Length; i++)
        result = IndexMinXWhereMinY(v,result,i);
    return result;
}
public static int MinXWhereMinY(this List<Vec2D> vertices)
{
    double minY = vertices.Min(v => v.y);
    double minX = vertices.Where(v => v.y == minY).Min(v => v.x);
    return vertices.FindIndex(v=>v.x==minX && v.y==minY);
}


    /*
public static int MinXWhereMinY(this Vector2[] v)
{
//if (v.ArrayIsNullOrEmpty())
//    throw new ArgumentException("Array is null or empty");
(int result, (float minX, float minY)) = (0,v[0]);
for (int i = 1; i < v.Length; i++)
{
if (v[i].y < minY )
    (result, (minX, minY)) = (i, v[i]);
else 
if (v[i].y==minY && v[i].x < minX)
    (result, (minX, minY)) = (i, v[i]);
}
return result;
}
*/
}