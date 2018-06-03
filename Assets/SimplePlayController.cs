using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayController : MonoBehaviour {
	
	void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, 0f, y).normalized * 3f * Time.deltaTime;

	}
}
