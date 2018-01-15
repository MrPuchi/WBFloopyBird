using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private float x;
    private float y;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        x = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        y = -1*Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        transform.Translate(x, y, 0);

    }
}
