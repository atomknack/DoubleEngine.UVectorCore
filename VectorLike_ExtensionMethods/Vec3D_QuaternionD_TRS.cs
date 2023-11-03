using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DoubleEngine
{
    public static partial class VectorUtil
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec3D Scaled(this Vec3D v, Vec3D b) => new Vec3D(v.x * b.x, v.y * b.y, v.z * b.z);
        public static Vec3D? Scaled(this Vec3D? v, Vec3D b) => v == null ? b : v.Value.Scaled(b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec3D Rotated(this Vec3D v, QuaternionD rotation) => rotation.Rotate(v);

        public static QuaternionD Rotated(this QuaternionD from, QuaternionD rotation) => from * rotation;
        public static QuaternionD? Rotated(this QuaternionD? from, QuaternionD rotation) => from == null ? rotation : from.Value.Rotated(rotation);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec3D Translated(this Vec3D v, Vec3D translation) => v + translation;
        public static Vec3D? Translated(this Vec3D? v, Vec3D translation) => v == null ? translation : v.Value.Translated(translation);
    }
}