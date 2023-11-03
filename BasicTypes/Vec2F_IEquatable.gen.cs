//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _Vector_IEquatable.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;

namespace DoubleEngine
{
    public readonly partial struct Vec2F : IEquatable<Vec2F>
    {
        public readonly bool Equals(Vec2F other)
        {
			//return x == other.x && y == other.y;
            return SpecialEquality(this, other);
        }
        
        public static bool operator !=(in Vec2F lhs, in Vec2F rhs)=> !(lhs == rhs);
        public static bool operator ==(in Vec2F lhs, in Vec2F rhs)=> SpecialEquality(lhs, rhs);
		public static bool SpecialEquality(in Vec2F lhs, in Vec2F rhs)
        {
			double xDiff = lhs.x - rhs.x;
			double yDiff = lhs.y - rhs.y;
            return xDiff *xDiff + yDiff *yDiff<1e-26;
        }
        public readonly override int GetHashCode()
        {
            int hash = 5903;
			hash = ((hash << 9) ^ hash) ^ x.GetHashCode();
			hash = ((hash << 9) ^ hash) ^ y.GetHashCode();
            return hash;
        }
        public readonly override bool Equals(object other)
        {
            if (!(other is Vec2F))
            {
                return false;
            }
            return Equals((Vec2F)other);
        }


    }
}
