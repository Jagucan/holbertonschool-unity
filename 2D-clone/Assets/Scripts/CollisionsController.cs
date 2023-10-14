using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsController : MonoBehaviour
{
    public bool isGrounded;
    public Transform groudCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Grounded();
    }

    public bool Grounded()
    {
        isGrounded = Physics2D.OverlapCircle(groudCheck.position, groundCheckRadius, groundLayer);
        return isGrounded;
    }
}
