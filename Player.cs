using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;

    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;

   
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;

        }

        horizontalInput = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, GetComponent<Rigidbody>().velocity.y, 0);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }
        if (jumpKeyWasPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 7, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }
    
}
    

