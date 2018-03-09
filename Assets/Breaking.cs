using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaking : MonoBehaviour {

    GameObject armPos;
    Vector3 originalPos;
    float punch;

    RaycastHit Rh;
    Renderer rnd;
    public Camera Mycam;

	void Start () {
        armPos = GameObject.FindGameObjectWithTag("Arm");
        originalPos = armPos.transform.localPosition;
        punch = 2f;
        rnd = GameObject.FindGameObjectWithTag("Block").GetComponent<Renderer>();
	}
	
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //    armPos.GetComponent<Rigidbody>().AddForce(Vector3.forward * punch);
        //else if (Input.GetKeyUp(KeyCode.Mouse0))
        //    armPos.transform.position = originalPos;

        var fwd = transform.TransformDirection(Vector3.forward);

        Ray ray = Mycam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 1f))
        {
            Physics.Raycast(transform.position, fwd, 1f);
            Debug.DrawLine(ray.origin, hit.point, Color.green);

            if (hit.transform.CompareTag("Block"))
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    hit.transform.GetComponent<Shader>();
                }
            }
        }

        
	}
}
