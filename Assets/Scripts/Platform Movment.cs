using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpforce = 10f;
    private bool isJumping = false;
    private Rigidbody2D rb;

    public Animator animator;

    float horizontalMovement = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //CODE FOR HORIZONTAL MOVMENT
        float horizontalInput = Input.GetAxis("Horizontal");
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed;
        Vector2 moveVector = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        animator.SetFloat("Walk", Mathf.Abs(horizontalMovement));

        //player is jumping
        if(Input.GetButtonDown("Jump")&& !isJumping){
            moveVector.y = jumpforce;
            isJumping = true;
            animator.SetBool("isJumping" , false);
        }
         rb.velocity = moveVector;

         if(horizontalInput < 0 ){
            transform.localScale = new Vector3(-1, 1, 1);
         }else if(horizontalInput > 0){
            transform.localScale = new Vector3(1, 1, 1);
         }

    }

    
    public void OnCollisionEnter2D(Collision2D collision){
    if(collision.gameObject.CompareTag("Ground")){
        isJumping = false;
        animator.SetBool("isJumping" , false);
    }
}
}
