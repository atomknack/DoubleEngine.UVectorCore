//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _Vector_IEquatable.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;

namespace VectorCore
{
    public readonly partial struct Vec2D : IEquatable<Vec2D>
    {
        public readonly bool Equals(Vec2D other)
        {
			//return x == other.x && y == other.y;
            return SpecialEquality(this, other);
        }
        
        public static bool operator !=(in Vec2D lhs, in Vec2D rhs)=> !(lhs == rhs);
        public static bool operator ==(in Vec2D lhs, in Vec2D rhs)=> SpecialEquality(lhs, rhs);
		public static bool SpecialEquality(in Vec2D lhs, in Vec2D rhs)
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
            if (!(other is Vec2D))
            {
                return false;
            }
            return Equals((Vec2D)other);
        }


    }
}

