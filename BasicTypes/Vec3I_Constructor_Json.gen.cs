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
    public readonly partial struct Vec3I
    {
		public readonly int x;
		public readonly int y;
		public readonly int z;

		[JsonConstructor]
		public Vec3I(int x = 0, int y = 0, int z = 0)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public void Deconstruct(out int x, out int y, out int z)
		{
			x = this.x;
			y = this.y;
			z = this.z;
		}
	}
}

