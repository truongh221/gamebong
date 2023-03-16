using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{   
     public  Rigidbody rb;
    public int speed = 200;
    public int turningspeed = 20; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0f, 0f, turningspeed * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0f, 0f, -turningspeed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(speed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("vatcan"))
        {
            this.enabled = false;
            FindObjectOfType<gamemanager>().Endgame();
        }
    }
}
