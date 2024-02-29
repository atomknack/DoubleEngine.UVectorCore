using System;
using System.Collections.Generic;
using System.Text;

namespace VectorCore;

public readonly struct TRS3D : IFormattable, IEquatable<TRS3D>
{
    public static readonly TRS3D DefaultTRS = new TRS3D(Vec3D.zero, QuaternionD.identity, Vec3D.scaleIdentity);

    public readonly Vec3D translation;
    public readonly QuaternionD rotation;
    public readonly Vec3D scale;

    public static TRS3D CreateFromTRS(Vec3D translation, QuaternionD rotation, Vec3D scale) =>
        new(translation, rotation, scale);
    public static TRS3D CreateFromTranslation(Vec3D translation) =>
        new(translation, QuaternionD.identity, Vec3D.scaleIdentity);
    public static TRS3D CreateFromRotation(QuaternionD rotation) =>
        new TRS3D(Vec3D.zero, rotation, Vec3D.scaleIdentity);
    public static TRS3D CreateFromScale(Vec3D scale) =>
        new(Vec3D.zero, QuaternionD.identity, scale);

    [Obsolete("Not tested")]
    public TRS3D TranslatedBy(Vec3D translation) =>
        new TRS3D(this.translation + translation, rotation, scale);
    [Obsolete("Not tested")]
    public TRS3D RotatedBy(QuaternionD rotation) =>
        new TRS3D(this.translation.Rotated(rotation), rotation * this.rotation, scale);
    /*

    [Obsolete("Not tested")]
    public TRS3D InvertedX() => new TRS3D(
            new Vec3D(-translation.x, translation.y, translation.z),
            new QuaternionD(rotation.x, -rotation.y, -rotation.z, rotation.w),
            new Vec3D(-scale.x, scale.y, scale.z));
    [Obsolete("Not tested")]
    public TRS3D InvertedY() => new TRS3D(
        new Vec3D(translation.x, -translation.y, translation.z),
        new QuaternionD(rotation.y, rotation.x, rotation.w, rotation.z),
        new Vec3D(scale.x, -scale.y, scale.z));
    [Obsolete("Not tested")]
    public TRS3D InvertedZ() => new TRS3D(
    new Vec3D(translation.x, translation.y, -translation.z),
    new QuaternionD(-rotation.z, rotation.w, -rotation.x, rotation.y),
    new Vec3D(scale.x, scale.y, -scale.z));
    */
    public MatrixD4x4 ToMatrixD4x4() => MatrixD4x4.FromTRS(translation, rotation, scale);

    public readonly override string ToString() =>
            $"({translation:F2}, {rotation:F2}, {scale:F2})";
    public readonly string ToString(string format) =>
            $"({translation.ToString(format)}, {rotation.ToString(format)}, {scale.ToString(format)})";
    public readonly string ToString(string format, IFormatProvider formatProvider) =>
            $"({translation.ToString(format, formatProvider)}, {rotation.ToString(format, formatProvider)}, {scale.ToString(format, formatProvider)})";

    public bool Equals(TRS3D other)
    {
        const double EPSILON = 0.000001d;
        return translation.CloseByEach(other.translation, EPSILON) 
            && QuaternionD.IsEqualOrFlippedEqual(rotation, other.rotation, EPSILON)
            && scale.CloseByEach(other.scale, EPSILON);
    }

    public TRS3D(Vec3D translation, QuaternionD rotation, Vec3D scale)
    {
        this.translation = translation;
        this.rotation = rotation;
        this.scale = scale;
    }
}
