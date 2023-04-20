using UnityEngine;

class Player : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float angularSpeed = 180;

    void Start() { }


    void Update()
    {
        Vector3 direction = GetInputDirection();

        if (direction != Vector3.zero)
        {
            Vector3 velocity = direction * speed;
            transform.position += velocity * Time.deltaTime;

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            Quaternion currentRotation = transform.rotation;


            // transform.rotation = Quaternion.LookRotation(direction); -> ez az egyszerábbnél, de ha smoothan akarok forogni, akkor:
            
            float step = angularSpeed * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, step);
            
        }
        
        
        
    }

    Vector3 GetInputDirection()
    {
        bool rightButton = Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D);
        bool leftButton = Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A); ;
        bool upButton = Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.W); ;
        bool downButton = Input.GetKey(KeyCode.DownArrow) | Input.GetKey(KeyCode.S); ;

        float x = 0;
        if (rightButton)
        {
            x += 1;
        }
        if (leftButton)
        {
            x -= 1;
        }

        float z = 0;
        if (upButton)
        {
            z += 1;
        }
        if (downButton)
        {
            z -= 1;
        }

        Vector3 d = new Vector3(x, 0, z);
        d.Normalize();
        return d;
    }

}

