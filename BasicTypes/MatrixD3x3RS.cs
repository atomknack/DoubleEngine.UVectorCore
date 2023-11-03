using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEngine;

[Obsolete("Not tested")]
public readonly partial struct MatrixD3x3RS
{
    public readonly static MatrixD3x3RS zero = new MatrixD3x3RS(
        0d, 0d, 0d,  0d, 0d, 0d,  0d, 0d, 0d);
    public readonly static MatrixD3x3RS identity = new MatrixD3x3RS(
        1d, 0d, 0d,  0d, 1d, 0d,  0d, 0d, 1d);
    public static MatrixD3x3RS FromRotation(QuaternionD rotation)
    {
        double xx = rotation.x * rotation.x;
        double xy = rotation.x * rotation.y;
        double xz = rotation.z * rotation.x;
        double xw = rotation.x * rotation.w;
        double yy = rotation.y * rotation.y;
        double yz = rotation.y * rotation.z;
        double yw = rotation.y * rotation.w;
        double zz = rotation.z * rotation.z;
        double zw = rotation.z * rotation.w;
        return new MatrixD3x3RS(
            1d - 2d * (yy + zz), 2d * (xy - zw), 2d * (xz + yw),
            2d * (xy + zw), 1d - 2d * (zz + xx), 2d * (yz - xw),
            2d * (xz - yw), 2d * (yz + xw), 1d - 2d * (yy + xx));
    }
    public static MatrixD3x3RS FromScale(Vec3D vector)
    {
        return new MatrixD3x3RS(
            vector.x, 0d, 0d,
            0d, vector.y, 0d,
            0d, 0d, vector.z);
    }

}

