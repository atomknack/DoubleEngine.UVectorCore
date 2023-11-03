//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _Vector_IEquatable.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;

namespace DoubleEngine
{
    public readonly partial struct Vec3I : IEquatable<Vec3I>
    {
        public readonly bool Equals(Vec3I other) => x == other.x && y == other.y && z == other.z;
        public static bool operator !=(in Vec3I lhs, in Vec3I rhs)=> !(lhs == rhs);
        public static bool operator ==(in Vec3I lhs, in Vec3I rhs)=> lhs.Equals(rhs);
        public readonly override int GetHashCode()
        {
            int hash = 5903;
			hash = ((hash << 5) ^ hash) ^ x.GetHashCode();
			hash = ((hash << 5) ^ hash) ^ y.GetHashCode();
			hash = ((hash << 5) ^ hash) ^ z.GetHashCode();
            return hash;
        }
        public readonly override bool Equals(object other)
        {
            if (!(other is Vec3I))
            {
                return false;
            }
            return Equals((Vec3I)other);
        }


    }
}
