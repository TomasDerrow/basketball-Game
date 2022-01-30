using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float speed = .0001f;

    private bool holdingBall = true;
    public float horizontalSpeed = 5f;
    public float verticalSpeed = 20f;
    public GameObject playerCamera;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        {


            

            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;

            }
        }

        Debug.Log("Here");
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * speed;

        /*
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = -1 * (verticalSpeed * Input.GetAxis("Mouse Y"));

        playerCamera.transform.Rotate(v, h, 0);
       */
       
        
    }
}



    

