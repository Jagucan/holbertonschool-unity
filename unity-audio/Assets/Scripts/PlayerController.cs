using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController player;
    private Transform transform;
    public Transform mainCamera;
    private Vector3 playerMovement = Vector3.zero;
    private Vector3 move = Vector3.zero;
    private Quaternion rotation;
    public float speed = 5f;
    public float jump = 10f;
    private float verticalMovement;
    public Canvas pauseMenu;
    private Transform ty;
    private Animator anim;
    private float fall = 0f;

    void Awake()
    {
        player = GetComponent<CharacterController>();
        transform = GetComponent<Transform>();
        ty = transform.Find("ty");
        anim = ty.GetComponent<Animator>();
    }

    void Update()
    {
        verticalMovement = playerMovement.y;
        playerMovement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            playerMovement = Vector3.forward + playerMovement;
        }
            
        if (Input.GetKey("s"))
        {
            playerMovement = Vector3.back + playerMovement;
        }
            
        if (Input.GetKey("d"))
        {
            playerMovement = Vector3.right + playerMovement;
        }
            
        if (Input.GetKey("a"))
        {
            playerMovement = Vector3.left + playerMovement;
        }
            
        playerMovement = ((mainCamera.right * playerMovement.x) + (mainCamera.forward * playerMovement.z)) * speed;
        
        if (player.isGrounded)
        {
            fall = 0;
            anim.SetBool("Grounded", true);

            if (Input.GetKeyDown("space"))
            {
                verticalMovement = jump;
                anim.SetTrigger("Jump");
            }
            else
            {
                verticalMovement = 0;    
            }
                
        }
        else
        {
            fall += Time.deltaTime;
            anim.SetBool("Grounded", false);
        }

        if (playerMovement != Vector3.zero)
        {
            move = new Vector3(playerMovement.x, 0, playerMovement.z);
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);
        }

        playerMovement.y = verticalMovement;
        playerMovement.y = playerMovement.y - (20 * Time.deltaTime);
        player.Move(new Vector3(playerMovement.x, playerMovement.y, playerMovement.z) * Time.deltaTime);

        if (playerMovement != Vector3.zero)
        {
            rotation = Quaternion.LookRotation(move);
            ty.rotation = rotation;
        }
        
        anim.SetFloat("Fall", fall);
        
        if (transform.position.y < -50.0f)
        {
            transform.position = new Vector3(0, 10, 0);
        }
            
        if (Input.GetKeyDown("escape"))
        {
            pauseMenu.GetComponent<PauseMenu>().Pause();
        }
    }
}
