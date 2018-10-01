using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour {
    public float rotateSpeed;
    private float z;
    // Use this for initialization
    void Start()
    {
        z = 0;
    }
    void Update()
    {
        bool right = Input.GetKey(KeyCode.D);
        bool left = Input.GetKey(KeyCode.A);
        if (right)
        {
            z += Time.deltaTime * rotateSpeed;
        }
        if (left)
        {
            z -= Time.deltaTime * rotateSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, z);
    }
}
