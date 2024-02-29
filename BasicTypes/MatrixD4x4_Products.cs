using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorCore
{
	public readonly partial struct MatrixD4x4
	{
		//[Obsolete("Please use TransformPointFull4x4 instead")]
		//public Vec3D MultiplyPoint(Vec3D point) => TransformPointFull4x4(point);
		//[Obsolete("Please use TransformPointTRS instead")]
		//public Vec3D MultiplyPoint3x4(Vec3D pointToTransform) => TransformPointTRS(pointToTransform);
		//[Obsolete("Please use TransformVectorRS instead")]
		//public Vec3D MultiplyVector(Vec3D vector) => TransformVectorRS(vector);
		/// <summary>Transform Point by full 4x4 Matrix: Translation,Rotation,Scale and special effects</summary>
		/// <remarks>for simple Point transformation use TransformPointTRS instead</remarks>
		/// <inheritdoc />
		public Vec3D MultiplyPoint(Vec3D point)
		{
			double project = 1d / (m30 * point.x + m31 * point.y + m32 * point.z + m33);
			return new Vec3D(
				(m00 * point.x + m01 * point.y + m02 * point.z + m03) * project,
				(m10 * point.x + m11 * point.y + m12 * point.z + m13) * project,
				(m20 * point.x + m21 * point.y + m22 * point.z + m23) * project);
		}
		public Vec3D MultiplyPoint3x4(Vec3D pointToTransform)
		{
			return new Vec3D(
				m00 * pointToTransform.x + m01 * pointToTransform.y + m02 * pointToTransform.z + m03,
				m10 * pointToTransform.x + m11 * pointToTransform.y + m12 * pointToTransform.z + m13,
				m20 * pointToTransform.x + m21 * pointToTransform.y + m22 * pointToTransform.z + m23);
		}

		public Vec3D MultiplyVector(Vec3D direction)
		{
			return new Vec3D(
				m00 * direction.x + m01 * direction.y + m02 * direction.z,
				m10 * direction.x + m11 * direction.y + m12 * direction.z,
				m20 * direction.x + m21 * direction.y + m22 * direction.z);
		}

	}
}
