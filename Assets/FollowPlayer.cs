using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    public float playerHeight;
    private bool holdingBall = true;
    public GameObject Basketball;
    public GameObject playerCamera;

    public float ballThrowingForce = 5f;

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        {
            transform.position = new Vector3(player.position.x, playerHeight, player.position.z) + offset;
            
            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                Basketball.GetComponent<Rigidbody>().useGravity = true;
                Basketball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
            }
        }
     
        
    }
}
