// Contains only the Vector2 swizzles

using UnityEngine;

public static class Vector2Swizzles
{
    // Vector2 Swizzles
    // 1 component (not recommended for use, but hey, up to you)
    public static Vector3 X__(this Vector2 v, float Y = 0, float Z = 0) { return new Vector3(v.x, Y, Z); }
    public static Vector3 _X_(this Vector2 v, float X = 0, float Z = 0) { return new Vector3(X, v.x, Z); }
    public static Vector3 __X(this Vector2 v, float X = 0, float Y = 0) { return new Vector3(X, Y, v.x); }
    public static Vector3 Y__(this Vector2 v, float Y = 0, float Z = 0) { return new Vector3(v.y, Y, Z); }
    public static Vector3 _Y_(this Vector2 v, float X = 0, float Z = 0) { return new Vector3(X, v.y, Z); }
    public static Vector3 __Y(this Vector2 v, float X = 0, float Y = 0) { return new Vector3(X, Y, v.y); }

    // 2 components
    public static Vector3 XY_(this Vector2 v, float Z = 0) { return new Vector3(v.x, v.y, Z); }
    public static Vector3 X_Y(this Vector2 v, float Y = 0) { return new Vector3(v.x, Y, v.y); }
    public static Vector3 YX_(this Vector2 v, float Z = 0) { return new Vector3(v.y, v.x, Z); }
    public static Vector3 _XY(this Vector2 v, float X = 0) { return new Vector3(X, v.x, v.y); }
    public static Vector3 Y_X(this Vector2 v, float Y = 0) { return new Vector3(v.y, Y, v.x); }
    public static Vector3 _YX(this Vector2 v, float X = 0) { return new Vector3(X, v.y, v.x); }
    public static Vector3 XX_(this Vector2 v, float Z = 0) { return new Vector3(v.x, v.x, Z); }
    public static Vector3 X_X(this Vector2 v, float Y = 0) { return new Vector3(v.x, Y, v.x); }
    public static Vector3 _XX(this Vector2 v, float X = 0) { return new Vector3(X, v.x, v.x); }
    public static Vector3 YY_(this Vector2 v, float Z = 0) { return new Vector3(v.y, v.y, Z); }
    public static Vector3 Y_Y(this Vector2 v, float Y = 0) { return new Vector3(v.y, Y, v.y); }
    public static Vector3 _YY(this Vector2 v, float X = 0) { return new Vector3(X, v.y, v.y); }

    // 3 components
    public static Vector3 XXX(this Vector2 v) { return new Vector3(v.x, v.x, v.x); }
    public static Vector3 YYY(this Vector2 v) { return new Vector3(v.y, v.y, v.y); }
    public static Vector3 XXY(this Vector2 v) { return new Vector3(v.x, v.x, v.y); }
    public static Vector3 XYX(this Vector2 v) { return new Vector3(v.x, v.y, v.x); }
    public static Vector3 YXX(this Vector2 v) { return new Vector3(v.y, v.x, v.x); }
    public static Vector3 YYX(this Vector2 v) { return new Vector3(v.y, v.y, v.x); }
    public static Vector3 YXY(this Vector2 v) { return new Vector3(v.y, v.x, v.y); }
    public static Vector3 XYY(this Vector2 v) { return new Vector3(v.x, v.y, v.y); }
}
