using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBlock : MonoBehaviour {

    public GameObject Block;
	
	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 2f))
        {
            print(hit.transform.name);
            if (Input.GetMouseButtonDown(0))
            {
                var b = Instantiate(Block, hit.transform.position + Vector3.up, Quaternion.identity);
            }
        }
    }
}
