//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _VectorLike_Common2.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

namespace VectorCore
{

public readonly partial struct Vec3D
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly double Magnitude()
    {
         return Math.Sqrt(MagnitudeSqr());
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Vec3D Normalized()
    {
        double mag = Magnitude();
        if (mag < 1E-06d)
            {
                return identity;
            }
            return new Vec3D(x / mag, y / mag, z / mag);
    }
    public readonly Vec3D ClampedMagnitude(double maxLength) //P
        {
            double sqrMagnitude = MagnitudeSqr();
            if (maxLength * maxLength >= sqrMagnitude)
                return this;
            if (sqrMagnitude <= 1E-09d) // test by Vec3D(0,0,0)
                return this;
            double magnitude = Math.Sqrt(sqrMagnitude);
            return DividedBy(magnitude).Multiplied(maxLength);
        }

}

}
