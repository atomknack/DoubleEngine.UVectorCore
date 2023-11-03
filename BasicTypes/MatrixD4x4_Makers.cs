using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEngine
{
    public readonly partial struct MatrixD4x4
    {
#if TESTING
        //[Obsolete("not tested")]
        public static MatrixD4x4 TESTING_FromTRS_Full_Slow(Vec3D translation, QuaternionD rotation, Vec3D scale) =>
            MatrixD4x4.FromTranslation(translation) * MatrixD4x4.FromRotation(rotation) * MatrixD4x4.FromScale(scale);
#endif
        public static MatrixD4x4 FromOperationRotateThenTranslate(QuaternionD rotation, Vec3D transform) =>
            MatrixD4x4.FromRotation(rotation).WithReplacedTranslation(transform);
        public static MatrixD4x4 FromOperationScaleThenRotateThenTranslate(Vec3D scale, QuaternionD rotation, Vec3D transform) =>
            (MatrixD4x4.FromRotation(rotation) * MatrixD4x4.FromScale(scale)).WithReplacedTranslation(transform);
        //MatrixD4x4 m = (MatrixD4x4.FromRotation(rotation) * MatrixD4x4.FromScale(scale)).WithReplacedTranslation(transform);

        ///for Unity compatiblity
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MatrixD4x4 Translate(Vec3D vector) =>
            MatrixD4x4.FromTranslation(vector);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MatrixD4x4 Rotate(QuaternionD rotation) =>
            MatrixD4x4.FromRotation(rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MatrixD4x4 Scale(Vec3D scale) =>
            MatrixD4x4.FromScale(scale);
        ///
        public static MatrixD4x4 FromTranslation(Vec3D vector)
        {
            return new MatrixD4x4( 
                1d, 0d, 0d, vector.x,
                0d, 1d, 0d, vector.y,
                0d, 0d, 1d, vector.z,
                0d, 0d, 0d, 1d);
        }
        [Obsolete("Not tested, maybe not working")]
        public static MatrixD4x4 FromRotationScale(QuaternionD rotation, Vec3D scale)
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
            return new MatrixD4x4(
                (1d - 2d * (yy + zz)) * scale.x, (2d * (xy - zw)) * scale.y, (2d * (xz + yw)) * scale.z, 0d,
                (2d * (xy + zw)) * scale.x, (1d - 2d * (zz + xx)) * scale.y, (2d * (yz - xw)) * scale.z, 0d,
                (2d * (xz - yw)) * scale.x, (2d * (yz + xw)) * scale.y, (1d - 2d * (yy + xx)) * scale.z, 0d,
                0d, 0d, 0d, 1d);
        }
        [Obsolete("Not tested, maybe not working")]
        public static MatrixD4x4 FromTRS(Vec3D translation, QuaternionD rotation, Vec3D scale)
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
            return new MatrixD4x4(
                (1d - 2d * (yy + zz)) * scale.x, (2d * (xy - zw)) * scale.y, (2d * (xz + yw)) * scale.z, translation.x,
                (2d * (xy + zw)) * scale.x, (1d - 2d * (zz + xx)) * scale.y, (2d * (yz - xw)) * scale.z, translation.y,
                (2d * (xz - yw)) * scale.x, (2d * (yz + xw)) * scale.y, (1d - 2d * (yy + xx)) * scale.z, translation.z,
                0d, 0d, 0d, 1d);
        }

        public static MatrixD4x4 FromRotation(QuaternionD rotation)
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
            return new MatrixD4x4(
                1d - 2d * (yy + zz), 2d * (xy - zw), 2d * (xz + yw), 0d,
                2d * (xy + zw), 1d - 2d * (zz + xx), 2d * (yz - xw), 0d,
                2d * (xz - yw), 2d * (yz + xw), 1d - 2d * (yy + xx), 0d,
                0d, 0d, 0d, 1d);
        }
        public static MatrixD4x4 FromScale(Vec3D vector)
        {
            return new MatrixD4x4(
                vector.x, 0d, 0d, 0d,
                0d, vector.y, 0d, 0d,
                0d, 0d, vector.z, 0d,
                0d, 0d, 0d, 1d);
        }

        /// <summary>Creates the look at matrix.</summary>
        /// <remarks> If looking at camera Up or Down, throws <c>ArgumentException</c> (check can be removed, but values are bad there (can be changes in direction).
        /// Don't look at camera Up, because where is Up gonna be when you looking at Up?
        /// In space, or water or flying - when you need to do full rotation around, you probably should: 
        /// 1) change Up with your move when you closing to UP(Down), or 2) calculate correct Up that is kind of orthogonal to
        /// your line (cameraPosition to cameraTarget) of looking. or 3) something else.</remarks>
        /// <exception cref="System.ArgumentException">Angle between target line and cameraUp vector too small</exception>
        /// <inheritdoc />
        public static MatrixD4x4 CreateLookAt(Vec3D cameraPosition, Vec3D cameraTarget, Vec3D cameraUpVector)
        {
            Vec3D vector = -(cameraPosition - cameraTarget).Normalized();
            Vec3D cross = Vec3D.Cross(cameraUpVector, vector);
            if (cross.IsZeroish(1E-10d))
                throw new ArgumentException("angle between camera Target and cameraUp vector too small");
            Vec3D vector2 = cross.Normalized();
            Vec3D vector3 = Vec3D.Cross(vector, vector2);
            return (new MatrixD4x4(
                vector2.x, vector3.x, vector.x, cameraPosition.x,
                vector2.y, vector3.y, vector.y, cameraPosition.y,
                vector2.z, vector3.z, vector.z, cameraPosition.z,
                0d, 0d, 0d, 1d
                ));
        }

    }
}
