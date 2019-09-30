using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody2D body;
    public float jumpForce;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //body = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            body.AddForce(transform.right * speed, ForceMode2D.Force);
            print("right");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            body.AddForce(transform.right * -speed, ForceMode2D.Force);
            print("left");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            body.AddForce(transform.up * jumpForce, ForceMode2D.Force);
            print("up");
        }
    }
}
