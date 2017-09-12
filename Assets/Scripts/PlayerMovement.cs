using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the rigid body component "rb"
    public Rigidbody rb;

    public float forwardForce = 2000;
    public float sidewaysForce = 500;

    // We marked this as "Fixed" Update because we
    // are using it to mess with physics.

    void FixedUpdate () {
        // Add a forward Force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Changing Movement Direction based on key being pressed
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }



    }
}
