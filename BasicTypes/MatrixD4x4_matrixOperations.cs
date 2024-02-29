using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorCore
{
    public readonly partial struct MatrixD4x4
    {
		public MatrixD4x4 WithReplacedTranslation(Vec3D newTranslation) =>
			new MatrixD4x4(
				m00, m01, m02, newTranslation.x,
				m10, m11, m12, newTranslation.y,
				m20, m21, m22, newTranslation.z,
				m30, m31, m32, m33);

		public MatrixD4x4 Transposed() => Transpose(this);
		public static MatrixD4x4 Transpose(MatrixD4x4 m)
		{
			return new MatrixD4x4(
			m.m00, m.m10, m.m20, m.m30,
			m.m01, m.m11, m.m21, m.m31,
			m.m02, m.m12, m.m22, m.m32,
			m.m03, m.m13, m.m23, m.m33);
		}

		public static MatrixD4x4 operator *(MatrixD4x4 lhs, MatrixD4x4 r) => Multiply(lhs, r);
		public MatrixD4x4 Multiplyed(MatrixD4x4 m) => Multiply(this, m);
		public static MatrixD4x4 Multiply(MatrixD4x4 lhs, MatrixD4x4 r)
		{
			return new MatrixD4x4( 
				lhs.m00*r.m00 + lhs.m01*r.m10 + lhs.m02*r.m20 + lhs.m03*r.m30, 
				lhs.m00*r.m01 + lhs.m01*r.m11 + lhs.m02*r.m21 + lhs.m03*r.m31,
				lhs.m00*r.m02 + lhs.m01*r.m12 + lhs.m02*r.m22 + lhs.m03*r.m32, 
				lhs.m00*r.m03 + lhs.m01*r.m13 + lhs.m02*r.m23 + lhs.m03*r.m33,

				lhs.m10*r.m00 + lhs.m11*r.m10 + lhs.m12*r.m20 + lhs.m13*r.m30, 
				lhs.m10*r.m01 + lhs.m11*r.m11 + lhs.m12*r.m21 + lhs.m13*r.m31,
				lhs.m10*r.m02 + lhs.m11*r.m12 + lhs.m12*r.m22 + lhs.m13*r.m32, 
				lhs.m10*r.m03 + lhs.m11*r.m13 + lhs.m12*r.m23 + lhs.m13*r.m33,

				lhs.m20*r.m00 + lhs.m21*r.m10 + lhs.m22*r.m20 + lhs.m23*r.m30, 
				lhs.m20*r.m01 + lhs.m21*r.m11 + lhs.m22*r.m21 + lhs.m23*r.m31,
				lhs.m20*r.m02 + lhs.m21*r.m12 + lhs.m22*r.m22 + lhs.m23*r.m32, 
				lhs.m20*r.m03 + lhs.m21*r.m13 + lhs.m22*r.m23 + lhs.m23*r.m33,

				lhs.m30*r.m00 + lhs.m31*r.m10 + lhs.m32*r.m20 + lhs.m33*r.m30, 
				lhs.m30*r.m01 + lhs.m31*r.m11 + lhs.m32*r.m21 + lhs.m33*r.m31,
				lhs.m30*r.m02 + lhs.m31*r.m12 + lhs.m32*r.m22 + lhs.m33*r.m32, 
				lhs.m30*r.m03 + lhs.m31*r.m13 + lhs.m32*r.m23 + lhs.m33*r.m33);
		}

		/*
		public static MatrixD4x4 operator *(MatrixD4x4 matrix, double value) => Multiply( matrix, value);
		public MatrixD4x4 Multiplyed(double d) => Multiply(this, d);
		public static MatrixD4x4 Multiply(MatrixD4x4 m, double d)
		{
			return new MatrixD4x4(
				m.m00 * d, m.m01 * d, m.m02 * d, m.m03 * d,
				m.m10 * d, m.m11 * d, m.m12 * d, m.m13 * d,
				m.m20 * d, m.m21 * d, m.m22 * d, m.m23 * d,
				m.m30 * d, m.m31 * d, m.m32 * d, m.m33 * d);
		}

		 
		public static MatrixD4x4 operator +(MatrixD4x4 value1, MatrixD4x4 value2) => Add(value1, value2);
		public MatrixD4x4 Added(MatrixD4x4 value) => Add(this, value);
		public static MatrixD4x4 Add(MatrixD4x4 lhs, MatrixD4x4 r)
		{
			return new MatrixD4x4( 
				lhs.m00 + r.m00, lhs.m01 + r.m01, lhs.m02 + r.m02, lhs.m03 + r.m03, 
				lhs.m10 + r.m10, lhs.m11 + r.m11, lhs.m12 + r.m12, lhs.m13 + r.m13, 
				lhs.m20 + r.m20, lhs.m21 + r.m21, lhs.m22 + r.m22, lhs.m23 + r.m23, 
				lhs.m30 + r.m30, lhs.m31 + r.m31, lhs.m32 + r.m32, lhs.m33 + r.m33);
		}

		public static MatrixD4x4 operator -(MatrixD4x4 lhs, MatrixD4x4 r) => Subtract(lhs, r);
		public MatrixD4x4 Subtracted(MatrixD4x4 subtraction) => Subtract(this, subtraction);
		public static MatrixD4x4 Subtract(MatrixD4x4 lhs, MatrixD4x4 r)
		{
			return new MatrixD4x4(
				lhs.m00 - r.m00, lhs.m01 - r.m01, lhs.m02 - r.m02, lhs.m03 - r.m03,
				lhs.m10 - r.m10, lhs.m11 - r.m11, lhs.m12 - r.m12, lhs.m13 - r.m13,
				lhs.m20 - r.m20, lhs.m21 - r.m21, lhs.m22 - r.m22, lhs.m23 - r.m23,
				lhs.m30 - r.m30, lhs.m31 - r.m31, lhs.m32 - r.m32, lhs.m33 - r.m33);
		}

		public static MatrixD4x4 operator -(MatrixD4x4 value) => Negate(value);

		public MatrixD4x4 Negated() => Negate(this);
		public static MatrixD4x4 Negate(MatrixD4x4 value)
		{
			return new MatrixD4x4(
				-value.m00, -value.m01, -value.m02, -value.m03,
				-value.m10, -value.m11, -value.m12, -value.m13,
				-value.m20, -value.m21, -value.m22, -value.m23,
				-value.m30, -value.m31, -value.m32, -value.m33);
		}
		*/

	}
}
