using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform center, obj1, obj2, resultVector;
    public Vector3 dir1 { get { return obj1.position - center.position; } }
    public Vector3 dir2 { get { return obj2.position - center.position; } }
    [Range(0,360)]
    public float angle = 0;

    public void Update()
    {
        resultVector.position = Utility.GetDir(dir1, center.position, angle);
    }
}
