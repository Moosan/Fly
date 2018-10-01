using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldRotate : MonoBehaviour {
    public float RotateSpeed;
    private float y;
    private void Update()
    {
        y += Time.deltaTime * RotateSpeed;
        transform.localRotation = Quaternion.Euler(0,180+y,0);
    }
}
