using UnityEngine;

public static class Utility
{
	public static float GetClockAngle(this Vector3 dir1, Vector3 dir2)
	{
		float dot = dir1.x * dir2.x + dir1.y * dir2.y;          //# dot product between [x1, y1] and [x2, y2]
		float det = dir1.x * dir2.y - dir1.y * dir2.x;          //# determinant
		float angle = Mathf.Atan2(det, dot) * Mathf.Rad2Deg;    //# atan2(y, x) or atan2(sin, cos)

		return (angle >= 0) ? angle : 360 - Mathf.Abs(angle);
	}

	/// <summary>
	/// Returns a vector with a rotation of angle degree in anticlockwise direction
	/// </summary>
	/// <param name="dir1"></param>
	/// <param name="center"></param>
	/// <param name="angle"> for random angle just pass a random angle</param>
	/// <returns></returns>
	public static Vector3 GetDir(this Vector3 dir1, Vector3 center, float angle)
	{
		float tempAngle = (angle + Vector3.right.GetClockAngle(dir1)) * Mathf.Deg2Rad; // in radians
		Vector3 resultDir = new Vector3(Mathf.Cos(tempAngle), Mathf.Sin(tempAngle), 0) + center;
		return resultDir;
	}

	public static float DotProduct(this Vector3 dir1, Vector3 dir2)
	{
		return (dir1.x * dir2.x + dir1.y * dir2.y + dir1.z * dir2.z);
	}

	public static Vector3 CrossProduct(this Vector3 dir1, Vector3 dir2)
	{
		return new Vector3(((dir1.y * dir2.z) - (dir1.z * dir2.y)), ((dir1.z * dir2.x) - (dir1.x * dir2.z)), ((dir1.x * dir2.y) - (dir1.y * dir2.x)));
	}
}
