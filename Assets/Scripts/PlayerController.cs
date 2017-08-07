using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D ball;
    public bool isGrounded;
    public Vector2 jump;
    public float jumpForce = 5.0f;


	// Use this for initialization
	void Start () {
		jump = new Vector3(0, 2);
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
	    {
	        ball.AddForce(jump * jumpForce, ForceMode2D.Impulse);
	        isGrounded = false;
	    }
	}
}
