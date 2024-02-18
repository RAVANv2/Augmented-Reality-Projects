using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveCamCloseAway = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, 0, moveCamCloseAway);

        // Camera movement in x-axis
        float leftRight = 0;
        if (Input.GetKey(KeyCode.A))
        {
            leftRight -= 1 * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            leftRight += 1 * speed * Time.deltaTime;
        }
        transform.Translate(leftRight, 0, 0);

        // Camera Rotate Code

        float roateCam = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            roateCam = roateCam - 1;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            roateCam = roateCam + 1;
        }

        transform.Rotate(0, roateCam, 0);

    }
}
