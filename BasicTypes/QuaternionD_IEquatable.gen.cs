﻿//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;

namespace VectorCore
{
    public readonly partial struct QuaternionD : IEquatable<QuaternionD>
    {
        public readonly bool Equals(QuaternionD other) => IsEqualOrFlippedEqual(this, other, 0.0000_0000_0000_1d);

        public static bool operator !=(in QuaternionD lhs, in QuaternionD rhs)=> !(lhs == rhs);
        public static bool operator ==(in QuaternionD lhs, in QuaternionD rhs)=> IsEqualOrFlippedEqual(lhs, rhs, 0.0000_0000_0000_1d);

        public readonly override int GetHashCode()
        {
            int hash = 0;
			hash = ((hash << 5) ^ hash) ^ x.GetHashCode();
			hash = ((hash << 5) ^ hash) ^ y.GetHashCode();
			hash = ((hash << 5) ^ hash) ^ z.GetHashCode();
			hash = ((hash << 5) ^ hash) ^ w.GetHashCode();
            return hash;
        }
        public readonly override bool Equals(object other)
        {
            if (!(other is QuaternionD))
            {
                return false;
            }
            return Equals((QuaternionD)other);
        }


    }
}
