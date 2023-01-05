using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    private float _xRotation;

    [SerializeField]public float _mouseSensitivity = 1200f;
    [SerializeField]private Transform Player;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Tracking();
    }

    private void Tracking()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        Player.Rotate(Vector3.up * mouseX);
    }
}
