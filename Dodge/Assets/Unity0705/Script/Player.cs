using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 8f;
    public Rigidbody playerRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*   if(Input.GetKey(KeyCode.UpArrow) == true)
           {
               playerRigidbody.AddForce(0f, 0f, speed);
           }
           if (Input.GetKey(KeyCode.DownArrow) == true)
           {
               playerRigidbody.AddForce(0f, 0f, -speed);
           }
           if (Input.GetKey(KeyCode.LeftArrow) == true)
           {
               playerRigidbody.AddForce(-speed, 0f, 0f);
           }
           if (Input.GetKey(KeyCode.RightArrow) == true)
           {
               playerRigidbody.AddForce(speed, 0f, 0f);
           }
           if (Input.GetKey(KeyCode.Space) == true)
           {
               playerRigidbody.AddForce(0f, speed*10, 0f);
           }*/

        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Z) == true)
        {
            playerRigidbody.AddForce(0f, speed * 10, 0f);
        }


        float xSpeed = xInput * speed;
        float ySpeed = yInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, ySpeed);
        playerRigidbody.velocity = newVelocity; 
    }

    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
