using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the RigidBody component called "rb"
    public Rigidbody rb;


    public float forwardforce = 2000f;
    public float sidewaysForce = 500f;
    public bool ApplyForce = true;
    // we marked this as "fixed"Uptade because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force
        if (forwardforce < 10000 && ApplyForce == true)
        {

            forwardforce = forwardforce + 2;
        
        }
            rb.AddForce(0, 0, forwardforce *Time.deltaTime);

        if(Input.GetKey("d"))
        {
           rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if(rb.position.y < -3f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
