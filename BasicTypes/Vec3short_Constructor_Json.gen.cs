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
    public readonly partial struct Vec3short
    {
		public readonly short x;
		public readonly short y;
		public readonly short z;

		[JsonConstructor]
		public Vec3short(short x = 0, short y = 0, short z = 0)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public void Deconstruct(out short x, out short y, out short z)
		{
			x = this.x;
			y = this.y;
			z = this.z;
		}
	}
}
