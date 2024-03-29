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
    public readonly partial struct MatrixD3x3RS
    {
		public readonly double m00;
		public readonly double m01;
		public readonly double m02;
		public readonly double m10;
		public readonly double m11;
		public readonly double m12;
		public readonly double m20;
		public readonly double m21;
		public readonly double m22;

		[JsonConstructor]
		public MatrixD3x3RS(double m00 = 1d, double m01 = 0d, double m02 = 0d, double m10 = 0d, double m11 = 1d, double m12 = 0d, double m20 = 0d, double m21 = 0d, double m22 = 1d)
		{
			this.m00 = m00;
			this.m01 = m01;
			this.m02 = m02;
			this.m10 = m10;
			this.m11 = m11;
			this.m12 = m12;
			this.m20 = m20;
			this.m21 = m21;
			this.m22 = m22;
		}

		public void Deconstruct(out double m00, out double m01, out double m02, out double m10, out double m11, out double m12, out double m20, out double m21, out double m22)
		{
			m00 = this.m00;
			m01 = this.m01;
			m02 = this.m02;
			m10 = this.m10;
			m11 = this.m11;
			m12 = this.m12;
			m20 = this.m20;
			m21 = this.m21;
			m22 = this.m22;
		}
	}
}

