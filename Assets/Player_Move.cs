using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
public class Player_Move : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent <Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX *7f,rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 7f);
        }
        if(dirX > 0f || dirX < 0 )
        {
            animator.SetBool("running", true);
        }
        else if(dirX == 0f)
        {
            animator.SetBool("running", false);
        }
        
    }
}
