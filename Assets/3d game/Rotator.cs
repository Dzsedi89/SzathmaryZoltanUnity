using UnityEngine;

class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    [SerializeField] Space space;
    [SerializeField] Vector3 axis = Vector3.up;
    
    void Update()
    {
        Vector3 axis = Vector3.up;
        transform.Rotate(axis, angularSpeed * Time.deltaTime, space);
    }

    void OnDrawGizmos()
    {
        Vector3 center = transform.position;
        Vector3 a = center + axis.normalized;
        Vector3 b = center - axis.normalized;
        

        Gizmos.DrawLine(a, b);    
    }
}
