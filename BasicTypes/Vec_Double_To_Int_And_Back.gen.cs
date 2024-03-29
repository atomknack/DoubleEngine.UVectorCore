﻿//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;

namespace VectorCore
{
    public readonly partial struct Vec2D : IConvertibleToOut<Vec2I>
    {
        public Vec2I ConvertTo(out Vec2I v)
        {
            v = ToVec2I(this);
            return v;
        }
        public Vec2I ToVec2I() => ToVec2I(this);
        public static Vec2I ToVec2I(Vec2D d) => new Vec2I((int)d.x, (int)d.y);
        public static Vec2D FromVec2I(Vec2I u) => new Vec2D(u.x, u.y);
    }

    public readonly partial struct Vec3D : IConvertibleToOut<Vec3I>
    {
        public Vec3I ConvertTo(out Vec3I v)
        {
            v = ToVec3I(this);
            return v;
        }
        public Vec3I ToVec3I() => ToVec3I(this);
        public static Vec3I ToVec3I(Vec3D d) => new Vec3I((int)d.x, (int)d.y, (int)d.z);
        public static Vec3D FromVec3I(Vec3I u) => new Vec3D(u.x, u.y, u.z);
    }


}