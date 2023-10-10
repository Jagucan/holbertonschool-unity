using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    
    private Vector2 angle = new(90 * Mathf.Deg2Rad, 0);
    public Transform follow;
    private float distance = -6.25f;
    public Vector2 sensitivity;
    public bool isInverted;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float hor = Input.GetAxis("Mouse X");

        if (hor != 0)
        {
            angle.x += hor * Mathf.Deg2Rad * sensitivity.x;
        }

        float ver = Input.GetAxis("Mouse Y");

        if (ver != 0)
        {
            if (isInverted == true)
            {
                angle.y -= ver * Mathf.Deg2Rad * sensitivity.y;
                angle.y = Mathf.Clamp(angle.y, -45 * Mathf.Deg2Rad, 15 * Mathf.Deg2Rad);
            }
            else if (isInverted == false)
            {
                angle.y += ver * Mathf.Deg2Rad * sensitivity.y;
                angle.y = Mathf.Clamp(angle.y, -45 * Mathf.Deg2Rad, 15 * Mathf.Deg2Rad);
            }
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 orbit = new(
            Mathf.Cos(angle.x) * Mathf.Cos(angle.y),
            Mathf.Sin(angle.y),
            Mathf.Sin(angle.x) * Mathf.Cos(angle.y)
            );

        transform.position = follow.position + orbit * distance;
        transform.rotation = Quaternion.LookRotation(follow.position - transform.position);
    }
}
