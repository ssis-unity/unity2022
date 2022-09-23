using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    float speed = 10.0f;
    float turnSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Successful started Unity Impact 2022 at SSIS. Fixed for GITHUB.");        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up")) //     forward
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("down")) //   back
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey("left")) //  <-
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("right")) //  ->
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W)) // W
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) // S
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        // from video https://youtu.be/1-uLP7GGcRc?t=478
        if (Input.GetKey(KeyCode.D)) // rotate left
        {
            transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.A)) // rotate right
        {
            transform.Rotate(0f, -turnSpeed * Time.deltaTime, 0f);
        }
        if (Input.GetKeyDown("space")) //  just print present coordinates to console
        {
            Debug.Log("Speed is " + speed + transform.position);
        }
    }
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Environment") {
            Debug.Log("I crashed into a tree.");
        }
    }
}
