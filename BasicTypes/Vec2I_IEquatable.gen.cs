//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _Vector_IEquatable.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;

namespace VectorCore
{
    public readonly partial struct Vec2I : IEquatable<Vec2I>
    {
        public readonly bool Equals(Vec2I other) => x == other.x && y == other.y;
        public static bool operator !=(in Vec2I lhs, in Vec2I rhs)=> !(lhs == rhs);
        public static bool operator ==(in Vec2I lhs, in Vec2I rhs)=> lhs.Equals(rhs);
        public readonly override int GetHashCode()
        {
            int hash = 5903;
			hash = ((hash << 9) ^ hash) ^ x.GetHashCode();
			hash = ((hash << 9) ^ hash) ^ y.GetHashCode();
            return hash;
        }
        public readonly override bool Equals(object other)
        {
            if (!(other is Vec2I))
            {
                return false;
            }
            return Equals((Vec2I)other);
        }


    }
}

