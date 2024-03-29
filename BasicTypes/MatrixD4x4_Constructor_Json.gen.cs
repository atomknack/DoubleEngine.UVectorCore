//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _VectorLike_Constructor_Json.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using Newtonsoft.Json;

namespace VectorCore
{
	[System.Serializable]	
    public readonly partial struct MatrixD4x4
    {
		public readonly double m00;
		public readonly double m01;
		public readonly double m02;
		public readonly double m03;
		public readonly double m10;
		public readonly double m11;
		public readonly double m12;
		public readonly double m13;
		public readonly double m20;
		public readonly double m21;
		public readonly double m22;
		public readonly double m23;
		public readonly double m30;
		public readonly double m31;
		public readonly double m32;
		public readonly double m33;

		[JsonConstructor]
		public MatrixD4x4(double m00 = 1d, double m01 = 0d, double m02 = 0d, double m03 = 0d, double m10 = 0d, double m11 = 1d, double m12 = 0d, double m13 = 0d, double m20 = 0d, double m21 = 0d, double m22 = 1d, double m23 = 0d, double m30 = 0d, double m31 = 0d, double m32 = 0d, double m33 = 1d)
		{
			this.m00 = m00;
			this.m01 = m01;
			this.m02 = m02;
			this.m03 = m03;
			this.m10 = m10;
			this.m11 = m11;
			this.m12 = m12;
			this.m13 = m13;
			this.m20 = m20;
			this.m21 = m21;
			this.m22 = m22;
			this.m23 = m23;
			this.m30 = m30;
			this.m31 = m31;
			this.m32 = m32;
			this.m33 = m33;
		}

		public void Deconstruct(out double m00, out double m01, out double m02, out double m03, out double m10, out double m11, out double m12, out double m13, out double m20, out double m21, out double m22, out double m23, out double m30, out double m31, out double m32, out double m33)
		{
			m00 = this.m00;
			m01 = this.m01;
			m02 = this.m02;
			m03 = this.m03;
			m10 = this.m10;
			m11 = this.m11;
			m12 = this.m12;
			m13 = this.m13;
			m20 = this.m20;
			m21 = this.m21;
			m22 = this.m22;
			m23 = this.m23;
			m30 = this.m30;
			m31 = this.m31;
			m32 = this.m32;
			m33 = this.m33;
		}
	}
}

