using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;

    void Update()
    {
        
        Vector3 targetPoint = target.position;
        Vector3 selfPoint = transform.position;
        /*                                          // ez rövidebb verzióban az alább lévõ live 1 sor.
        Vector3 dir= targetPoint - selfPoint;
        dir.Normalize();

        Vector3 velocity = dir * speed;
        transform.position += velocity * Time.deltaTime;
        */
        transform.position = Vector3.MoveTowards(selfPoint, targetPoint, speed * Time.deltaTime);
        
        //--------------Forgás a lookat.cs-ben--------------//
        
    }
}
