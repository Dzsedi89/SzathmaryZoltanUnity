using UnityEngine;

class LookAt : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 targetOffset;
    [SerializeField] bool enableVerticalTurn = true;

    void Update()
    {
        Vector3 targetPoint = target.position + targetOffset;
        Vector3 selfPoint = transform.position;
        Vector3 dir = targetPoint - selfPoint;
        
        if (!enableVerticalTurn)
        {
            float y = transform.rotation.eulerAngles.y;
            dir.y = y;
        }

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);
        }
    }
}
