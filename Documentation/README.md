# Documentation

In hopefully chronological order the progress of our club will be documented


## 2022/09/16 Create first object, define variables of correct type and write first lines of code

<img src="20220919_yaw.png" align="right" width="30%">

We had an introduction to variables, declaration (C# is statically typed) and possible types (int, float, char, string, bool) and name conventions. After that a Kahoot! checked if we payed attention. Only 2 of 14 students scored 8/8!

You can follow the instructions on Youtube in [this video created by Soleil](https://youtu.be/1-uLP7GGcRc).

- Create a new project in Unity
- Add a cube
- Add the material "Red"
- Add the C# script "moveCube"
- Connect the script to the cube
- Enjoy your first interactive program!

Working code or script looks like this:

``` c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    float speed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Successful started Unity Impact 2022 at SSIS.");        
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

```

## 2022/09/09 First meeting - What to expect

<img src="20220919_asg_itch.io.png" align="right" width="25%">

We want to create games, so the first meeting was about clarifying the objective for ourselves. Plus links to the software to install to be ready to code for the next session. We need:

- [Unity](https://unity.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)
