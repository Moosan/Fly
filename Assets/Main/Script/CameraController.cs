using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    //public GameObject Player;
    private Vector3 startPos;
    private Vector3 cameraPos;
    void Start () {
        startPos = transform.position;
        //cameraPos = startPos-Player.transform.position;
    }

	void Update () {
        transform.position = /*Player.transform.position*/new Vector3() + cameraPos;

	}
}

