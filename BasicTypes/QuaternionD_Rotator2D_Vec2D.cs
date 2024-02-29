using System;

namespace VectorCore
{
	public readonly partial struct QuaternionD
	{
		private readonly ref struct Rotator2D // need full all methods testing
		{
			readonly double m00; readonly double m01;
			readonly double m10; readonly double m11;
			public Rotator2D(in QuaternionD rotation)
			{
				double x2 = rotation.x * 2d; double y2 = rotation.y * 2d; double z2 = rotation.z * 2d;
				double xx2 = rotation.x * x2; double yy2 = rotation.y * y2; double zz2 = rotation.z * z2;
				double xy2 = rotation.x * y2;
				double wz2 = rotation.w * z2;
				m00 = (1d - (yy2 + zz2)); m01 = (xy2 - wz2);
				m10 = (xy2 + wz2); m11 = (1d - (xx2 + zz2));
			}
			public readonly Vec2D Rotate(in Vec2D v) => new Vec2D((m00 * v.x + m01 * v.y), (m10 * v.x + m11 * v.y));
		}

		public readonly Vec2D Rotate(Vec2D vec) => new Rotator2D(this).Rotate(vec);
		public readonly void RotateInPlace(Vec2D[] rotateInPlace)
		{
			Span<Vec2D> span = new Span<Vec2D>(rotateInPlace);
			Rotate(span, span);
		}
		public readonly Vec2D[] Rotate(Vec2D[] toRotate)
		{
			Vec2D[] newArray = new Vec2D[toRotate.Length];
			Rotate(new ROSpanVec2D(toRotate), new Span<Vec2D>(newArray));
			return newArray;
		}
		public readonly void Rotate(ROSpanVec2D vIn, Span<Vec2D> vOut)
		{
			if (vIn.Length > vOut.Length)
				throw new ArgumentException("vIn Length should not be bigger than vOut Length");
			Rotator2D rotator = new Rotator2D(this);

			for (int i = 0; i < vIn.Length; i++)
				vOut[i] = rotator.Rotate(vIn[i]);

		}
	}
}