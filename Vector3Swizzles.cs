// Only the swizzles that take in a Vector3 as an argument.

using UnityEngine;

public static class Vector3Swizzles
{
    // Vector3 Swizzles
    // 1 component (not recommended for use, but hey, up to you)
    public static Vector3 X__(this Vector3 v, float Y = 0, float Z = 0) { return new Vector3(v.x, Y, Z); }
    public static Vector3 _X_(this Vector3 v, float X = 0, float Z = 0) { return new Vector3(X, v.x, Z); }
    public static Vector3 __X(this Vector3 v, float X = 0, float Y = 0) { return new Vector3(X, Y, v.x); }
    public static Vector3 Y__(this Vector3 v, float Y = 0, float Z = 0) { return new Vector3(v.y, Y, Z); }
    public static Vector3 _Y_(this Vector3 v, float X = 0, float Z = 0) { return new Vector3(X, v.y, Z); }
    public static Vector3 __Y(this Vector3 v, float X = 0, float Y = 0) { return new Vector3(X, Y, v.y); }
    public static Vector3 Z__(this Vector3 v, float Y = 0, float Z = 0) { return new Vector3(v.z, Y, Z); }
    public static Vector3 _Z_(this Vector3 v, float X = 0, float Z = 0) { return new Vector3(X, v.z, Z); }
    public static Vector3 __Z(this Vector3 v, float X = 0, float Y = 0) { return new Vector3(X, Y, v.z); }

    // 2 component combinations
    public static Vector3 XY_(this Vector3 v, float Z = 0) { return new Vector3(v.x, v.y, Z); }
    public static Vector3 X_Y(this Vector3 v, float Y = 0) { return new Vector3(v.x, Y, v.y); }
    public static Vector3 XZ_(this Vector3 v, float Z = 0) { return new Vector3(v.x, v.z, Z); }
    public static Vector3 X_Z(this Vector3 v, float Y = 0) { return new Vector3(v.x, Y, v.z); }
    public static Vector3 YX_(this Vector3 v, float Z = 0) { return new Vector3(v.y, v.x, Z); }
    public static Vector3 _XY(this Vector3 v, float X = 0) { return new Vector3(X, v.x, v.y); }
    public static Vector3 ZX_(this Vector3 v, float Z = 0) { return new Vector3(v.z, v.x, Z); }
    public static Vector3 _XZ(this Vector3 v, float X = 0) { return new Vector3(X, v.x, v.z); }
    public static Vector3 Y_X(this Vector3 v, float Y = 0) { return new Vector3(v.y, Y, v.x); }
    public static Vector3 Z_X(this Vector3 v, float Y = 0) { return new Vector3(v.z, Y, v.x); }
    public static Vector3 _YX(this Vector3 v, float X = 0) { return new Vector3(X, v.y, v.x); }
    public static Vector3 _ZX(this Vector3 v, float X = 0) { return new Vector3(X, v.z, v.x); }
    public static Vector3 YZ_(this Vector3 v, float Z = 0) { return new Vector3(v.y, v.z, Z); }
    public static Vector3 Y_Z(this Vector3 v, float Y = 0) { return new Vector3(v.y, Y, v.z); }
    public static Vector3 ZY_(this Vector3 v, float Z = 0) { return new Vector3(v.z, v.y, Z); }
    public static Vector3 _YZ(this Vector3 v, float X = 0) { return new Vector3(X, v.y, v.z); }
    public static Vector3 Z_Y(this Vector3 v, float Y = 0) { return new Vector3(v.z, Y, v.y); }
    public static Vector3 _ZY(this Vector3 v, float X = 0) { return new Vector3(X, v.z, v.y); }
    public static Vector3 XX_(this Vector3 v, float Z = 0) { return new Vector3(v.x, v.x, Z); }
    public static Vector3 X_X(this Vector3 v, float Y = 0) { return new Vector3(v.x, Y, v.x); }
    public static Vector3 _XX(this Vector3 v, float X = 0) { return new Vector3(X, v.x, v.x); }
    public static Vector3 YY_(this Vector3 v, float Z = 0) { return new Vector3(v.y, v.y, Z); }
    public static Vector3 Y_Y(this Vector3 v, float Y = 0) { return new Vector3(v.y, Y, v.y); }
    public static Vector3 _YY(this Vector3 v, float X = 0) { return new Vector3(X, v.y, v.y); }
    public static Vector3 ZZ_(this Vector3 v, float Z = 0) { return new Vector3(v.z, v.z, Z); }
    public static Vector3 Z_Z(this Vector3 v, float Y = 0) { return new Vector3(v.z, Y, v.z); }
    public static Vector3 _ZZ(this Vector3 v, float X = 0) { return new Vector3(X, v.z, v.z); }

    // 3 components
    public static Vector3 XYZ(this Vector3 v) { return new Vector3(v.x, v.y, v.z); }
    public static Vector3 XZY(this Vector3 v) { return new Vector3(v.x, v.z, v.y); }
    public static Vector3 YXZ(this Vector3 v) { return new Vector3(v.y, v.x, v.z); }
    public static Vector3 YZX(this Vector3 v) { return new Vector3(v.y, v.z, v.x); }
    public static Vector3 ZXY(this Vector3 v) { return new Vector3(v.z, v.x, v.y); }
    public static Vector3 ZYX(this Vector3 v) { return new Vector3(v.z, v.y, v.x); }

    public static Vector3 XXX(this Vector3 v) { return new Vector3(v.x, v.x, v.x); }
    public static Vector3 YYY(this Vector3 v) { return new Vector3(v.y, v.y, v.y); }
    public static Vector3 ZZZ(this Vector3 v) { return new Vector3(v.z, v.z, v.z); }

    public static Vector3 XXY(this Vector3 v) { return new Vector3(v.x, v.x, v.y); }
    public static Vector3 XXZ(this Vector3 v) { return new Vector3(v.x, v.x, v.z); }
    public static Vector3 XYX(this Vector3 v) { return new Vector3(v.x, v.y, v.x); }
    public static Vector3 XZX(this Vector3 v) { return new Vector3(v.x, v.z, v.x); }
    public static Vector3 YXX(this Vector3 v) { return new Vector3(v.y, v.x, v.x); }
    public static Vector3 ZXX(this Vector3 v) { return new Vector3(v.z, v.x, v.x); }

    public static Vector3 YYX(this Vector3 v) { return new Vector3(v.y, v.y, v.x); }
    public static Vector3 YYZ(this Vector3 v) { return new Vector3(v.y, v.y, v.z); }
    public static Vector3 YXY(this Vector3 v) { return new Vector3(v.y, v.x, v.y); }
    public static Vector3 YZY(this Vector3 v) { return new Vector3(v.y, v.z, v.y); }
    public static Vector3 XYY(this Vector3 v) { return new Vector3(v.x, v.y, v.y); }
    public static Vector3 ZYY(this Vector3 v) { return new Vector3(v.z, v.y, v.y); }

    public static Vector3 ZZX(this Vector3 v) { return new Vector3(v.z, v.z, v.x); }
    public static Vector3 ZZY(this Vector3 v) { return new Vector3(v.z, v.z, v.y); }
    public static Vector3 ZXZ(this Vector3 v) { return new Vector3(v.z, v.x, v.z); }
    public static Vector3 ZYZ(this Vector3 v) { return new Vector3(v.z, v.y, v.z); }
    public static Vector3 XZZ(this Vector3 v) { return new Vector3(v.x, v.z, v.z); }
    public static Vector3 YZZ(this Vector3 v) { return new Vector3(v.y, v.z, v.z); }
}
