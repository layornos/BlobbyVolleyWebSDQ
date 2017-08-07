using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D ball;
    public bool isGrounded;
    public Vector2 jump;
    public Vector2 move;
    public float jumpForce = 5.0f;


	// Use this for initialization
	void Start () {
		jump = new Vector2(0, 2);
        move = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
	    {
	        ball.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            jumpForce = 1;
	        isGrounded = false;
	    }

        if (!ball.IsTouching(GameObject.Find("Background").GetComponent<EdgeCollider2D>()))
            isGrounded = false;
        else
        {
            jumpForce = 5;
            isGrounded = true;
        }

        if (Input.GetKeyDown(KeyCode.U))
            ball.transform.Translate(Vector2.left * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.A))
            ball.transform.Translate(Vector2.right * Time.deltaTime);

     
	}
}
