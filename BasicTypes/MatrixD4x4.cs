using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorCore
{
	/// <inheritdoc /> 
	public readonly partial struct MatrixD4x4
    {
		
		[Obsolete("need testing, probably not working, maybe need switch rows and colls")]
		public Vec3D ScaleMaybe()
        {
			float xs = (Math.Sign(m00 * m10 * m20 * m30) < 0) ? -1 : 1;
			float ys = (Math.Sign(m01 * m11 * m21 * m31) < 0) ? -1 : 1;
			float zs = (Math.Sign(m02 * m12 * m22 * m32) < 0) ? -1 : 1;

			var scaleX = xs * Math.Sqrt(m00 * m00 + m10 * m10 + m20 * m20);
			var scaleY = ys * Math.Sqrt(m01 * m01 + m11 * m11 + m21 * m21);
			var scaleZ = zs * Math.Sqrt(m02 * m02 + m12 * m12 + m22 * m22);
			return new Vec3D(scaleX, scaleY, scaleZ);
        }

	}
}
