using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float jumpSpeed;
    private Vector3 StartPos;
    private void Start()
    {
        StartPos = transform.position;
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Space)) {
            if(GetComponent<Rigidbody>().velocity.y<=0.2&&transform.position.y<=StartPos.y+0.2)
            GetComponent<Rigidbody>().velocity = new Vector3(0,jumpSpeed,0);
        }
	}
}
