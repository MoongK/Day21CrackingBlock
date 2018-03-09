using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMover : MonoBehaviour {

    public float MouseMove = 0f;
    float verticalRotation = 0f;

	void Start () {
        MouseMove = 100f;
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	void Update () {
        float MouseX = Input.GetAxisRaw("Mouse X");
        float MouseY = Input.GetAxisRaw("Mouse Y");

        verticalRotation += MouseY * MouseMove * Time.deltaTime;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);


        transform.Rotate(new Vector3(0f, MouseX, 0f) * MouseMove * Time.deltaTime);
        transform.Find("Sight Camera").transform.localRotation = Quaternion.Euler(-verticalRotation, 0f, 0f);


        if (Input.GetKeyDown(KeyCode.Escape))
            Cursor.lockState = CursorLockMode.None;
        else if (Input.GetKeyDown(KeyCode.Mouse1))
            Cursor.lockState = CursorLockMode.Locked;
	}
}
