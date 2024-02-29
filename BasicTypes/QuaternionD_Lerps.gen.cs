using System;

namespace VectorCore
{
    public readonly partial struct QuaternionD
    {
        public static QuaternionD Lerp(QuaternionD quaternion1, QuaternionD quaternion2, double amount) =>
            LerpUnclamped(quaternion1, quaternion2, Math.Clamp(amount, 0d, 1d));
        public static QuaternionD LerpUnclamped(QuaternionD quaternion1, QuaternionD quaternion2, double amount)
		{
			double invAmount = 1d - amount;
			double dot = Dot(quaternion1, quaternion2);
			if (dot >= 0d)
			{
				return ((quaternion1 * invAmount) + (quaternion2 * amount)).Normalized();
			}
			return ((quaternion1 * invAmount) - (quaternion2 * amount)).Normalized();
		}

		public static QuaternionD Slerp(QuaternionD quaternion1, QuaternionD quaternion2, double amount) =>
			SlerpUnclamped(quaternion1, quaternion2, Math.Clamp(amount, 0d, 1d));
		public static QuaternionD SlerpUnclamped(QuaternionD quaternion1, QuaternionD quaternion2, double amount)
		{
			double dot = Dot(quaternion1, quaternion2);
			double dotSign = Math.Sign(dot);
			dot = Math.Abs(dot);
			double dotAcos = Math.Acos(dot);
			double dotAcosSin = Math.Sin(dotAcos);
			double scale1 = Math.Sin((1d - amount) * dotAcos) / dotAcosSin;
			double scale2 = Math.Sin(amount * dotAcos) / dotAcosSin;
			scale2 = scale2 * dotSign;
			return ((quaternion1 * scale1) + (quaternion2 * scale2));//.Normalized();
		}
	}
}
