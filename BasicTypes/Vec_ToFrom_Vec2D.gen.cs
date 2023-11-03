//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Vec_ToFrom_Vectorlike.tt. 
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;

namespace DoubleEngine
{
    public readonly partial struct Vec2D : IConvertibleToOut<Vec2F>
    {
        public Vec2F ConvertTo(out Vec2F v)
        {
            Vec2F t = ToVec2F(this);
            v = t;
            return t;
        }
        public Vec2F ToVec2F() => ToVec2F(this);
        public static Vec2F ToVec2F(Vec2D d) => new Vec2F((float)d.x, (float)d.y);
        public static Vec2D FromVec2F(Vec2F u) => new Vec2D(u.x, u.y);
        
        [Obsolete("use To or From Convertion method")]
        public static explicit operator Vec2F(Vec2D d) =>ToVec2F(d);
        [Obsolete("use To or From Convertion method")]
        public static explicit operator Vec2D(Vec2F u) => FromVec2F(u);
        
    }
}
