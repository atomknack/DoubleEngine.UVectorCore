using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEngine
{
    /// <inheritdoc /> 
    public readonly partial struct QuaternionD
    {
        public static QuaternionD Flip(QuaternionD q) => new QuaternionD(-q.x, -q.y, -q.z, -q.w);
        public readonly QuaternionD Flipped() => new QuaternionD(-x, -y, -z, -w);


        public static QuaternionD AngleAxis(double angleDegrees, Vec3D axis)
        {
            return AngleAxisHalfRadians(MathU.DegreesToHalfRadians(angleDegrees), axis);
            /*Vec3D nAxis = axis.Normalized();
            double angle = MathU.DegreesToHalfRadians(angleDegrees);
            double s = Math.Sin(angle);
            return new QuaternionD(s * nAxis.x, s * nAxis.y, s * nAxis.z, Math.Cos(angle));*/
        }
        public static QuaternionD AngleRadiansAxis(double angleDegrees, Vec3D axis)
            =>AngleAxisHalfRadians(MathU.RadiansToHalfRadians(angleDegrees), axis);

        public static QuaternionD AngleAxisHalfRadians(double angleHalfRadians, Vec3D axis)
        {
            Vec3D nAxis = axis.Normalized();
            double s = Math.Sin(angleHalfRadians);
            return new QuaternionD(s * nAxis.x, s * nAxis.y, s * nAxis.z, Math.Cos(angleHalfRadians));
        }

        public static QuaternionD EulerRadians(Vec3D v) => EulerRadians(v.x, v.y, v.z);
        public static QuaternionD EulerRadians(double x, double y, double z) => EulerHalfRadians(x / 2d, y / 2d, z / 2d);
        // roll (X), pitch (Y), yaw (Z), 
        public static QuaternionD Euler(Vec3D v) => EulerDegrees(v);
        public static QuaternionD EulerDegrees(Vec3D v) =>
            EulerHalfRadians(MathU.DegreesToHalfRadians(v.x), MathU.DegreesToHalfRadians(v.y), MathU.DegreesToHalfRadians(v.z));
        public static QuaternionD Euler(double x, double y, double z) => EulerDegrees(x, y, z);
        public static QuaternionD EulerDegrees(double x, double y, double z)
        {
            return EulerHalfRadians(MathU.DegreesToHalfRadians(x), MathU.DegreesToHalfRadians(y), MathU.DegreesToHalfRadians(z));
        }
        private static QuaternionD EulerHalfRadians(double hrX, double hrY, double hrZ)
        {
            QuaternionD qX = new QuaternionD(Math.Sin(hrX), 0, 0, Math.Cos(hrX));
            QuaternionD qY = new QuaternionD(0, Math.Sin(hrY), 0, Math.Cos(hrY));
            QuaternionD qZ = new QuaternionD(0, 0, Math.Sin(hrZ), Math.Cos(hrZ));
            return HamiltonProduct(HamiltonProduct(qY, qX), qZ);
        }

        public static QuaternionD FromRotationMatrix(MatrixD4x4 m)
        {
            double s;
            double fs;
            if (m.m00 + m.m11 + m.m22 > 0f)
            {
                s = Math.Sqrt((m.m00 + m.m11 + m.m22 + 1f));
                fs = 0.5d / s;
                return new QuaternionD( (m.m21 - m.m12) * fs, (m.m02 - m.m20) * fs, (m.m10 - m.m01) * fs, 0.5d*s );
            }
            if (m.m00 >= m.m11 && m.m00 >= m.m22)
            {
                s = Math.Sqrt((1f + m.m00 - m.m11 - m.m22));
                fs = 0.5d / s;
                return new QuaternionD(  0.5d * s, (m.m10 + m.m01) * fs, (m.m20 + m.m02) * fs, (m.m21 - m.m12) * fs );
            }
            if (m.m11 > m.m22)
            {
                s = Math.Sqrt((1f + m.m11 - m.m00 - m.m22));
                fs = 0.5d / s;
                return new QuaternionD( (m.m10 + m.m01) * fs, 0.5d * s, (m.m21 + m.m12) * fs, (m.m02 - m.m20) * fs );
            }
            s = Math.Sqrt((1f + m.m22 - m.m00 - m.m11));
            fs = 0.5d / s;
            return new QuaternionD( (m.m20 + m.m02) * fs, (m.m21 + m.m12) * fs, 0.5d * s, (m.m10 - m.m01) * fs );
        }

        /// <summary>Creates Look At Quaternion, up is Vec3.up</summary> <inheritdoc cref="MatrixD4x4.CreateLookAt"/> 
        public static QuaternionD LookRotation(Vec3D forward) => LookRotation(forward, Vec3D.up);
        /// <summary>Creates Look At Quaternion</summary> <inheritdoc cref="MatrixD4x4.CreateLookAt"/> 
        public static QuaternionD LookRotation(Vec3D forward, Vec3D up) => 
            FromRotationMatrix(MatrixD4x4.CreateLookAt(Vec3D.zero, forward, up));

    }
}
