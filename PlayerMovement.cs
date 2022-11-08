using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        //dont do player movement in update, frame rate isn't god to rely on for physics.
        //Input is better
        movement.x = Input.GetAxisRaw("Horizontal");  //input gives -1 for A, 1 for D
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() 
    {
    	//Movement
    	rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }

}
