using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 12.0f;
    private float turnSpeed=28.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //change the speed based on input manage responding to the keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle forward with some speed
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        //set the speed when turning, and let it rotate, not just slide.

        transform.Rotate(Vector3.up,turnSpeed*horizontalInput*Time.deltaTime);
    }
}
