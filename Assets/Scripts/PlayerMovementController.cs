using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    //Setting players movement speed
    public float playerSpeed = 10f;
    private Rigidbody2D playerBody;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        animator =  GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(h, v);

        playerBody.velocity =   movement.normalized * playerSpeed;

        animator.SetBool("isFlyingLeft", h < 0);

        animator.SetBool("isFlyingUp", v > 0);

        animator.SetBool("isFlyingRight", h > 0);

    
    }
}
