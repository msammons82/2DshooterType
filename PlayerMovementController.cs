using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rigidbody;
    private Animator animator;
     

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Here we get wether A or D was pressed(or left and right arrow keys)
        float h = Input.GetAxis("Horizontal");
        //Here we get wether S or W was pressed(or up and Down arrow keys)
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h,v);

        rigidbody.velocity = dir.normalized * speed;

        animator.SetBool("isFlyingLeft", h < 0);
        animator.SetBool("isFlyingUp", v > 0);
        animator.SetBool("isFlyingRight", h > 0);
        




    }
}
