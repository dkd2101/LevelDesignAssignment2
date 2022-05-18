using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;

    public float teleportX;
    public float teleportY;
    public float teleportZ;

    public bool walkedFarEnough = false;

    private float xRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    public void teleport(float mouseY)
    {
        if (walkedFarEnough)
        {

            if (this.playerBody.localEulerAngles.y > 90 && this.playerBody.localEulerAngles.y < 180);
            {
                print("Teleport");
                this.playerBody.position = new Vector3(teleportX, teleportY, teleportZ);
                
            }
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        print("walkedFarEnough");
        walkedFarEnough = true;
    }
}