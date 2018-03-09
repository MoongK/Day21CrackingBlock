using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

    float MoveSpeed;
    bool isGround = true;

    void Start () {
        MoveSpeed = 3f;
	}
	
	void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 MoveDir = new Vector3(x, 0f, z);
        MoveDir = transform.TransformDirection(MoveDir) * MoveSpeed * Time.deltaTime;

        MoveDir += transform.position;
        transform.position = MoveDir;

        
        if (isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                transform.GetComponent<Rigidbody>().AddForce(Vector3.up * 100f);
        }

    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    if (!other.collider)
    //        isGround = false;
    //    else
    //        isGround = true;


    //}
}
