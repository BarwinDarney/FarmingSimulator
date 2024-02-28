using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    public float moveSpeed = 10f;
    public Rigidbody2D theRB;
    public Animator animator;
    public VectorValue startingPosition;

    Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startingPosition.initialValue;
        transform.position = startingPosition.initialValue;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement animations and controls
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }
       
    void FixedUpdate()
    {
        //Move Character position
        theRB.MovePosition(theRB.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    
}
