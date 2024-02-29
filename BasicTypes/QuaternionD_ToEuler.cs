using System;
using System.Runtime.CompilerServices;

namespace VectorCore
{
    public readonly partial struct QuaternionD
    {
		public static double ComputeXAngle(QuaternionD q)
		{
			double sinr_cosp = 2 * (q.w * q.x + q.y * q.z);
			double cosr_cosp = 1 - 2 * (q.x * q.x + q.y * q.y);
			return Math.Atan2(sinr_cosp, cosr_cosp);
		}

		public static double ComputeYAngle(QuaternionD q)
		{
			double sinp = 2 * (q.w * q.y - q.z * q.x);
			if (Math.Abs(sinp) >= 1)
				return Math.PI / 2 * Math.Sign(sinp); // use 90 degrees if out of range
			else
				return Math.Asin(sinp);
		}

		public static double ComputeZAngle(QuaternionD q)
		{
			double siny_cosp = 2 * (q.w * q.z + q.x * q.y);
			double cosy_cosp = 1 - 2 * (q.y * q.y + q.z * q.z);
			return Math.Atan2(siny_cosp, cosy_cosp);
		}

		public static Vec3D CoputeAngles(QuaternionD q)
		{
			return new Vec3D(ComputeXAngle(q), ComputeYAngle(q), ComputeZAngle(q));
		}


		public Vec3D ToEulerDegrees() 
		{
			return Vec3D.DegreesTo360PositiveDegrees(Vec3D.Round(Vec3D.RadiansToDegrees(QuaternionToEulerRadians(this)),8)); 
		}


        public static Vec3D QuaternionToEulerRadians(QuaternionD q) //P
        {
            double nonNormalizedCorrection = (q.x * q.x) + (q.y * q.y) + (q.z * q.z) + (q.w * q.w);
            double singularity = q.x * q.w - q.y * q.z;

            if (singularity > 0.49999995f * nonNormalizedCorrection) // we have singularity case at north pole
                return new Vec3D(Math.PI / 2, 2f * Math.Atan2(q.y, q.x), 0);

            if (singularity < -0.49999995f * nonNormalizedCorrection) // we have singularity case at south pole
				return new Vec3D( -Math.PI / 2, -2f * Math.Atan2(q.y, q.x), 0);

            return new Vec3D(
                Math.Asin(2f * (q.w * q.x - q.y * q.z)),
                Math.Atan2(2f * q.w * q.y + 2f * q.z * q.x, 1 - 2f * (q.x * q.x + q.y * q.y)),
                Math.Atan2(2f * q.w * q.z + 2f * q.x * q.y, 1 - 2f * (q.z * q.z + q.x * q.x))
                );
        }

        /*static Vec3D NormalizeAngles3(Vec3D angles)=> new Vec3D(NormalizeAngle3(angles.x), NormalizeAngle3(angles.y), NormalizeAngle3(angles.z));

        static double NormalizeAngle3(double angle)
        {
            while (angle > Math.PI * 2f)
                angle -= Math.PI * 2f;
            while (angle < 0)
                angle += Math.PI * 2f;
            return angle;
        }*/


    }
}
