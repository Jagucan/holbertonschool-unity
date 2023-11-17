using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float turn = 3f;
    public Transform player;
    private Transform transform;
    private Vector3 orbit;
    private Quaternion angleX;
    private Quaternion angleY;
    public bool isInverted;

    void Awake()
    {
        if (PlayerPrefs.GetInt("Y", 0) == 0)
        {
            isInverted = false;
        }
        else
        {
            isInverted = true;
        }

        transform = GetComponent<Transform>();
    }

    void Start()
    {   
        orbit = new Vector3(0, 1.25f, -6.25f);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void LateUpdate()
    {
        angleX = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turn, Vector3.up);
        
        if (isInverted == true)
        {
            angleY = Quaternion.AngleAxis(-1 * (Input.GetAxis("Mouse Y") * turn), Vector3.left);
        }
        else
        {
            angleY = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turn, Vector3.left);
        }
        
        orbit = angleX * angleY * orbit;
        transform.position = player.position + orbit;
        transform.LookAt(player.position + new Vector3(0, 0.24f, 0));
    }
}
