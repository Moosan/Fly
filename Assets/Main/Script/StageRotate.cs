using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageRotate : MonoBehaviour {
    public float zRotate;
    public float yRotate;
    private float z;
    private float y;
    private int range;

    private Vector3 center;
	// Use this for initialization
	void Start () {
        z = 0;
        y = 0;
	}
    void Update()
    {
        bool right = Input.GetKey(KeyCode.D);
        bool left = Input.GetKey(KeyCode.A);
        if (right)
        {
            z += Time.deltaTime * zRotate;
        }
        if (left)
        {
            z -= Time.deltaTime * zRotate;
        }
        y += Time.deltaTime * yRotate;
        transform.rotation = Quaternion.Euler(0, y, z);
    }
}
