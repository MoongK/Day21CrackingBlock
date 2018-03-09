using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBlock : MonoBehaviour {
	

	void Update () {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 1f) && hit.collider.tag == "Block")
        {
            
            if (Input.GetMouseButton(0))
                hit.collider.gameObject.GetComponent<BreakUp>().Hit();
        }
	}
}
