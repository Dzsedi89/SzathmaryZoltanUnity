using UnityEngine;

class ClickExploder : MonoBehaviour
{
    [SerializeField] Transform cursorTransform;
    [SerializeField] float range = 10;
    [SerializeField] float maxImpulse = 10;
    [SerializeField] LayerMask clickMask;

    ParticleSystem particleSys;
    Renderer cursorRenderer;
    AudioSource audioSource;

    private void Start()
    {
        particleSys = cursorTransform.GetComponent<ParticleSystem>();
        cursorRenderer = cursorTransform.GetComponent<Renderer>();
        audioSource= cursorTransform.GetComponent<AudioSource>();
    }


    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);

        bool isHit = Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, clickMask);

        //cursorTransform.gameObject.SetActive(isHit);
        cursorRenderer.enabled = isHit;

        if (isHit)
        {
            // Debug.Log($"Hit:  {hit.collider.name}   -   {hit.point}");
            cursorTransform.position = hit.point;

            if (Input.GetMouseButtonDown(0))
            {
                Explode(hit.point);
            }
        }
    }

    void Explode(Vector3 point)
    {
        particleSys.Play();
        audioSource.Play();
        
        Rigidbody[] allRigidbodies = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody rb in allRigidbodies) 
        {
            Vector3 distanceVector = (rb.position - point);
            float distance = (rb.position - point).magnitude;
            if (distance > range)
                continue;

            //ellökés:
            Vector3 direction = distanceVector / distance;
            float m = 1 - (distance / range);
            float impulse = maxImpulse * m;
            rb.AddForce(direction * impulse, ForceMode.Impulse);
            
            //ellökés


        }
    }
}
