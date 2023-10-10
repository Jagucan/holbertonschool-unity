using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public new Transform camera;
    public float jumpHeight;
    public float speed = 4;
    private float gravity = -9.8f;
    private bool groundedPlayer;

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 movement = Vector3.zero;
        groundedPlayer = characterController.isGrounded;

        if (hor != 0 || ver != 0)
        {
            Vector3 forward = camera.forward;
            forward.y = 0;
            forward.Normalize();

            Vector3 right = camera.right;
            right.y = 0;
            right.Normalize();

            Vector3 direction = forward * ver + right * hor;
            float movementSpeed = Mathf.Clamp01(direction.magnitude);
            direction.Normalize();

            movement = movementSpeed * speed * Time.deltaTime * direction;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.2f);
        }
        /*
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            movement.y += jumpHeight - 2f * gravity;
            Debug.Log("jump");
        }
        */
        movement.y += gravity * Time.deltaTime;
        characterController.Move(movement);
    }
}