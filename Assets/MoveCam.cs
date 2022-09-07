using UnityEngine;

public class MoveCam : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            turnAround(transform.position, gameObject, 45f);
        }
    }

    public void turnAround(Vector2 point, GameObject obj, float angle)
    {
        Vector3 point3 = new Vector3(point.x, point.y, 0);
        Vector3 axis = new Vector3(0, 0, 1);
        obj.transform.RotateAround(point3, axis, angle);
    }
}
