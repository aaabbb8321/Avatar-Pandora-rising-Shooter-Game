using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrushti : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    float yRotation = 0f;
    public Vector2 LookAxis;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = LookAxis.x * mouseSensitivity * Time.deltaTime;
        float mouseY = LookAxis.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        yRotation += mouseX;

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        playerBody.Rotate(Vector3.up*mouseX);
    }
}
