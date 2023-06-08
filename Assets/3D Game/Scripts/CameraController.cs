using UnityEngine;

[ExecuteAlways]

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    //[SerializeField] Vector3 distanceVector;
    //[SerializeField] float verticalDistance = 10;
    //[SerializeField] float horizontalDistance = 10;
    [SerializeField] float distance = 10;
    [SerializeField] public float verticalAngle = 30;
    [SerializeField] public float horizontalAngle = 0;
    
    void LateUpdate()
    {
        FreshCamera();
    }

    void FreshCamera()
    {
       // transform.position = target.position + target.TransformVector(distanceVector); <-- a célponthoz képesti vektor, ezzel fogja követni pl forogni vele.
        
        float verticalDistance = distance * Mathf.Sin(verticalAngle * Mathf.Deg2Rad);
        float horizontalDistance = distance * Mathf.Cos(verticalAngle * Mathf.Deg2Rad);

        float xDistance = horizontalDistance * Mathf.Sin(horizontalAngle * Mathf.Deg2Rad);
        float zDistance = horizontalDistance * Mathf.Cos(horizontalAngle * Mathf.Deg2Rad);

        Vector3 distanceVector = new Vector3 (xDistance,verticalDistance,zDistance);

        transform.position = distanceVector + target.position;

        transform.LookAt(target);
    }
}
