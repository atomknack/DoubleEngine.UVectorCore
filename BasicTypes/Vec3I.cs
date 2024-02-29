using CollectionLike;
using Newtonsoft.Json;
using System;

namespace VectorCore
{
    public readonly partial struct Vec3I
    {
        public readonly static Vec3I zero = new Vec3I(0, 0, 0);
        public readonly static Vec3I one = new Vec3I(1, 1, 1);
        public readonly static Vec3I forward = new Vec3I(0, 0, 1);
        public readonly static Vec3I up = new Vec3I(0, 1, 0);
        public readonly static Vec3I right = new Vec3I(1, 0, 0);
        public readonly static Vec3I back = new Vec3I(0, 0, -1);
        public readonly static Vec3I down = new Vec3I(0, -1, 0);
        public readonly static Vec3I left = new Vec3I(-1, 0, 0);

        public readonly static Vec3I[] s_corners = { new Vec3I(-1, -1, -1),new Vec3I(1, -1, -1), new Vec3I(-1, 1, -1), new Vec3I(1, 1,-1),
                                                     new Vec3I(-1, -1,  1),new Vec3I(1, -1,  1), new Vec3I(-1, 1,  1), new Vec3I(1, 1, 1)};
        public static ReadOnlySpan<Vec3I> Corners => s_corners.AsReadOnlySpan<Vec3I>();

        //public readonly override string ToString() =>
        //$"({x},{y},{z})";

        public Vec3short ToVec3short() => new Vec3short((short)x, (short)y, (short)z);
    }
}

