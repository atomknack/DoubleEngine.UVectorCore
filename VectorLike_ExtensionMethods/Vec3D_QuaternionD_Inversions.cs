using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleEngine;

public static partial class VectorUtil
{
    public static QuaternionD InvertedByZ(this QuaternionD q) => new QuaternionD(-q.x, -q.y, q.z, q.w);
    [Obsolete("Not tested")]
    public static Vec3D InvertedByZ(this Vec3D v) => new Vec3D(v.x, v.y, -v.z);

    [Obsolete("Not tested")]
    public static QuaternionD InvertedByY(this QuaternionD q) => new QuaternionD(-q.x, q.y, -q.z, q.w);
    [Obsolete("Not tested")]
    public static Vec3D InvertedByY(this Vec3D v) => new Vec3D(v.x, -v.y, v.z);

    [Obsolete("Not tested")]
    public static QuaternionD InvertedByX(this QuaternionD q) => new QuaternionD(q.x, -q.y, -q.z, q.w);
    [Obsolete("Not tested")]
    public static Vec3D InvertedByX(this Vec3D v) => new Vec3D(-v.x, v.y, v.z);
}
