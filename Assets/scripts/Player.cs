
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private float movespeed = 5f;
    private void Update()
    {
        Vector2 inputVector=new Vector2(0,0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = 1;
        }
        if(Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if(Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if(Input.GetKey(KeyCode.D))
        {
            inputVector.x = 1;
        }
       // Player movement logic here
       inputVector=inputVector.normalized;
        //Adding movement to the player object capsule 
        //assigning the vector 3 to only two axis from vector 2 to make it 2D movement
        Vector3 moveDir=new Vector3(inputVector.x,0f,inputVector.y);
        
        transform.position += moveDir * Time.deltaTime* movespeed;

        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime);
        // Normalize the input vector to ensure consistent movement speed
        //deltatime is the time that elapsed between two consecutive frames 
       Debug.Log(Time.deltaTime);
    }
}
