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
    public readonly partial struct Vec2I
    {
		public readonly int x;
		public readonly int y;

		[JsonConstructor]
		public Vec2I(int x = 0, int y = 0)
		{
			this.x = x;
			this.y = y;
		}

		public void Deconstruct(out int x, out int y)
		{
			x = this.x;
			y = this.y;
		}
	}
}

