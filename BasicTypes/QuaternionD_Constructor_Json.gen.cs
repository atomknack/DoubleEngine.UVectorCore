//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a _VectorLike_Constructor_Json.tt
//     Changes will be lost if the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------
using Newtonsoft.Json;

namespace DoubleEngine
{
	[System.Serializable]	
    public readonly partial struct QuaternionD
    {
		public readonly double x;
		public readonly double y;
		public readonly double z;
		public readonly double w;

		[JsonConstructor]
		public QuaternionD(double x = 0d, double y = 0d, double z = 0d, double w = 1d)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public void Deconstruct(out double x, out double y, out double z, out double w)
		{
			x = this.x;
			y = this.y;
			z = this.z;
			w = this.w;
		}
	}
}
