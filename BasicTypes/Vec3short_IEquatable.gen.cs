//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _Vector_IEquatable.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;

namespace DoubleEngine
{
    public readonly partial struct Vec3short : IEquatable<Vec3short>
    {
        public readonly bool Equals(Vec3short other)
        {
			//return x == other.x && y == other.y && z == other.z;
            return SpecialEquality(this, other);
        }
        
        public static bool operator !=(in Vec3short lhs, in Vec3short rhs)=> !(lhs == rhs);
        public static bool operator ==(in Vec3short lhs, in Vec3short rhs)=> SpecialEquality(lhs, rhs);
		public static bool SpecialEquality(in Vec3short lhs, in Vec3short rhs)
        {
			double xDiff = lhs.x - rhs.x;
			double yDiff = lhs.y - rhs.y;
			double zDiff = lhs.z - rhs.z;
            return xDiff *xDiff + yDiff *yDiff + zDiff *zDiff<1e-26;
        }
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
            if (!(other is Vec3short))
            {
                return false;
            }
            return Equals((Vec3short)other);
        }


    }
}
