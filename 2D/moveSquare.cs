using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSquare : MonoBehaviour
{
    float speed = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Successful started Unity Impact 2023 at SSIS.");        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }        
        if (Input.GetKey("space"))
        {
            Debug.Log("Speed is " + speed + transform.position);
        }        
    }
}
