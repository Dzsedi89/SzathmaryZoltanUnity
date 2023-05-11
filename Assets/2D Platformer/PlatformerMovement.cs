using UnityEngine;

class PlatformerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float acceleration = 10;
    [SerializeField] float deceleration;
    [SerializeField] float maxSpeed = 10;
    [SerializeField] float jumpSpeed = 10;
    [SerializeField] new Rigidbody2D rigidbody;

    bool isGrounded = false;

    private void OnValidate()
    {
        if(rigidbody == null)
            rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() //EMMEGMI? A sima update minden képfrissítés elõtt fut le. Ez úgy tûnik, mintha beállított érték lenne a képfrissítések száma. Gyorsuló mozgásnál FIXED update
                        //-et kell használni.
    {
        float x = Input.GetAxis("Horizontal");
        Vector2 velocity = rigidbody.velocity;
        if (x == 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, deceleration * Time.fixedDeltaTime);
        }

        else
        {
            Vector2 accelerationVec = new Vector2(x * acceleration, 0);

            //velocity.x = x * movementSpeed;
            velocity += accelerationVec * Time.fixedDeltaTime;



            if (Mathf.Abs(velocity.x) > maxSpeed) velocity.x = maxSpeed * Mathf.Sign(velocity.x);

            
        }
        

        //függõleges mozgás

        
        
        rigidbody.velocity = velocity;
    }

    private void Update()
    {
        Vector2 velocity = rigidbody.velocity;
        bool jump = Input.GetKeyDown(KeyCode.Space);

        if (jump && isGrounded)
        {
            velocity.y = jumpSpeed;
        }
        rigidbody.velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded= true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded= false;
    }

}
