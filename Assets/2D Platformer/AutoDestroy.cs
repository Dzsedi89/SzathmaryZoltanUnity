using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] float destroyTime;
    [SerializeField] float maxDistance;

    Vector3 startPosition;

    float startTime;

    private void Start()
    {
        //startTime = Time.time;
        Invoke(nameof(DestroySelf), destroyTime);
        startPosition= transform.position;
    }
    /*
    void Update()
    {
        float age = Time.time - startTime;

        if(age > destroyTime)
        {
            Destroy(gameObject);
        }
    }
    */

    private void Update()
    {
        if((startPosition - transform.position).magnitude > maxDistance)
                DestroySelf();
    }

    void DestroySelf() => Destroy(gameObject);
}
