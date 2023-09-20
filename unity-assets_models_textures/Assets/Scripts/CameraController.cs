using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public float camSpeedRotation;
    // Start is called before the first frame update
    void Start()
    {
        // Cursor Options.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Controls for Player Camera Rotation.
        float mouseX = Input.GetAxis("Mouse X") * camSpeedRotation * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);
    }
}
