using System;

namespace VectorCore
{
    public readonly partial struct QuaternionD
    {
		public readonly static QuaternionD identity = new QuaternionD(0, 0, 0, 1d);

		public static bool IsEqualOrFlippedEqual(QuaternionD a, QuaternionD b, double epsilon = 1e-7d) //need to be tested that it works in separate test 
        {
			if (Math.Abs(a.x - b.x) < epsilon && Math.Abs(a.y - b.y) < epsilon && Math.Abs(a.z - b.z) < epsilon && Math.Abs(a.w - b.w) < epsilon)
				return true;
			if (Math.Abs(a.x + b.x) < epsilon && Math.Abs(a.y + b.y) < epsilon && Math.Abs(a.z + b.z) < epsilon && Math.Abs(a.w + b.w) < epsilon)
				return true;
			return false;
		}
		public readonly QuaternionD Inversed() => new QuaternionD(-x, -y, -z, w);
		
		public readonly double Angle(QuaternionD other) => Angle(this, other);
		public static double Angle(QuaternionD a, QuaternionD b) =>
			MathU.HalfRadiansToDegrees(Math.Acos(Math.Min(Math.Abs(Dot(a, b)), 1d)));

		/// <inheritdoc cref = "ToAngleAxisHalfRadians" />
		public readonly (double angle, Vec3D axis) ToAngleAxisDegrees()
		{
			(double angle, Vec3D axis) = ToAngleAxisHalfRadians();
			return (MathU.HalfRadiansToDegrees(angle), axis);
		}
		/// <inheritdoc cref = "ToAngleAxisHalfRadians" />
		public readonly (double angle, Vec3D axis) ToAngleAxisRadians()
		{
			(double angle, Vec3D axis) = ToAngleAxisHalfRadians();
			return (angle * 2d, axis);
		}
		/// <summary>Quaternion to Angle and Axis</summary>
		/// <remarks> if Quaternion is at singularity position return Vec3D.right as vector</remarks>
		/// <inheritdoc />
		public readonly (double angle, Vec3D axis) ToAngleAxisHalfRadians()
        {
			double MINS = 1E-7d;
			double s =Math.Sqrt(1 - w * w);
			if (s < MINS)
				return (Math.Acos(w),Vec3D.right); //return (Math.Acos(w), new Vec3D(x, y, z));
			return (Math.Acos(w), new Vec3D(x / s, y / s, z / s));
		}
		public static QuaternionD operator *(QuaternionD lhs, QuaternionD rhs) => HamiltonProduct(lhs, rhs);
		public static QuaternionD HamiltonProduct(QuaternionD lhs, QuaternionD rhs) => new QuaternionD(
				lhs.w * rhs.x + lhs.x * rhs.w + lhs.y * rhs.z - lhs.z * rhs.y,
				lhs.w * rhs.y + lhs.y * rhs.w + lhs.z * rhs.x - lhs.x * rhs.z,
				lhs.w * rhs.z + lhs.z * rhs.w + lhs.x * rhs.y - lhs.y * rhs.x,
				lhs.w * rhs.w - lhs.x * rhs.x - lhs.y * rhs.y - lhs.z * rhs.z);

///Use this only if you need rotate only one Vector by Quaternion once, 
///because it equal to:
///1 creation of rotation matrix, 
///2 rotate vector by matrix
///3 discard created matrix
		public static Vec3D operator *(QuaternionD rotation, Vec3D vec) => rotation.Rotate(vec);
		public readonly Vec3D Rotate(Vec3D vec)
        {
			double x2 = x * 2d;  double y2 = y * 2d;  double z2 = z * 2d;
			double xx2 = x * x2; double yy2 = y * y2; double zz2 = z * z2;
			double xy2 = x * y2; double xz2 = x * z2; double yz2 = y * z2;
			double wx2 = w * x2; double wy2 = w * y2; double wz2 = w * z2;
			return new Vec3D(
(1d - (yy2 + zz2)) * vec.x + (xy2 - wz2) * vec.y +        (xz2 + wy2) * vec.z,
(xy2 + wz2) * vec.x +        (1d - (xx2 + zz2)) * vec.y + (yz2 - wx2) * vec.z,
(xz2 - wy2) * vec.x +        (yz2 + wx2) * vec.y +        (1d - (xx2 + yy2)) * vec.z
				);
		}

		public readonly void RotateInPlace(Vec3D[] rotateInPlace) // need testing
		{
			Span<Vec3D> span = new Span<Vec3D>(rotateInPlace);
			Rotate(span, span);
		}
		public readonly Vec3D[] Rotate(Vec3D[] toRotate) // need testing
		{
			Vec3D[] newArray = new Vec3D[toRotate.Length];
			Rotate(new ReadOnlySpan<Vec3D>(toRotate), new Span<Vec3D>(newArray));
			return newArray;
		}
		public readonly void Rotate(ReadOnlySpan<Vec3D> vIn, Span<Vec3D> vOut) // need testing
        {
			if(vIn.Length>vOut.Length)
				throw new ArgumentException("vIn Length should not be bigger than vOut Length");
			double x2 = x * 2d;  double y2 = y * 2d;  double z2 = z * 2d;
			double xx2 = x * x2; double yy2 = y * y2; double zz2 = z * z2;
			double xy2 = x * y2; double xz2 = x * z2; double yz2 = y * z2;
			double wx2 = w * x2; double wy2 = w * y2; double wz2 = w * z2;
			for (int i = 0; i<vIn.Length; i++)
				{
				Vec3D vec = vIn[i];
				vOut[i] = new Vec3D(
(1d - (yy2 + zz2)) * vec.x + (xy2 - wz2) * vec.y +        (xz2 + wy2) * vec.z,
(xy2 + wz2) * vec.x +        (1d - (xx2 + zz2)) * vec.y + (yz2 - wx2) * vec.z,
(xz2 - wy2) * vec.x +        (yz2 + wx2) * vec.y +        (1d - (xx2 + yy2)) * vec.z
				);
				}
		}
		
	}

}