using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.15f;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, newPos, smoothSpeed);
        transform.position = smoothPos;

        transform.LookAt(target);
    }
}
