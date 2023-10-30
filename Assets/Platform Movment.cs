using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovment : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpforce = 10f;
    private bool isJumping = false;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetAxis<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //CODE FOR HORIZONTAL MOVMENT
        float horizontalInput = Input.GetAxis("Horizontal")
        Vector2 moveVector = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        //player is jumping
        if(Input.GetButtondown("jump")&& !isjumping){
            moveVector.y = jumpforce;
            isJumping = true;
            rb.velocity = moveVector;
        }


    }

    
    private void OnCollision2D(Collision2D collision)
    if(collosion.gameObject.Compare("Ground"))
}
