//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _Vector_IEquatable.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;

namespace VectorCore
{
    public readonly partial struct Vec4D : IEquatable<Vec4D>
    {
        public readonly bool Equals(Vec4D other)
        {
			//return x == other.x && y == other.y && z == other.z && w == other.w;
            return SpecialEquality(this, other);
        }
        
        public static bool operator !=(in Vec4D lhs, in Vec4D rhs)=> !(lhs == rhs);
        public static bool operator ==(in Vec4D lhs, in Vec4D rhs)=> SpecialEquality(lhs, rhs);
		public static bool SpecialEquality(in Vec4D lhs, in Vec4D rhs)
        {
			double xDiff = lhs.x - rhs.x;
			double yDiff = lhs.y - rhs.y;
			double zDiff = lhs.z - rhs.z;
			double wDiff = lhs.w - rhs.w;
            return xDiff *xDiff + yDiff *yDiff + zDiff *zDiff + wDiff *wDiff<1e-26;
        }
        public readonly override int GetHashCode()
        {
            int hash = 5903;
			hash = ((hash << 5) ^ hash) ^ x.GetHashCode();
			hash = ((hash << 5) ^ hash) ^ y.GetHashCode();
			hash = ((hash << 5) ^ hash) ^ z.GetHashCode();
			hash = ((hash << 5) ^ hash) ^ w.GetHashCode();
            return hash;
        }
        public readonly override bool Equals(object other)
        {
            if (!(other is Vec4D))
            {
                return false;
            }
            return Equals((Vec4D)other);
        }


    }
}

