using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sidewayForce = 500f;

    // We marked this as "Fixed"Update becase we
    // are using it to mess with physics.
    void FixedUpdate()
    { 
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a force of 2000 on the z-axis

        if (Input.GetKey("d"))
        {
            // only executed if condition is met
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a"))
        {
            // only executed if condition is met
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            Debug.Log("Falling");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
