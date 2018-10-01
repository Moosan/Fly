using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseMover : MonoBehaviour {
    public float RotateSpeed;
    public GameObject Road;
    private float y;
    public int CircleCount;
    public float r;
    // Update is called once per frame
    public int T;
    void Update()
    {
        y += Time.deltaTime * RotateSpeed;
        transform.localRotation = Quaternion.Euler(0, y, 0);
    }

    void Start() {
        float range1 = 0;
        float range1delta = 360 / ((float)CircleCount*T);
        Vector3 Rcenter = transform.localPosition;
        float R = Rcenter.magnitude;

        float range2 = -90;
        float range2delta = 360 / T;
        while (range1<360)
        {
            float omega1 = range1 * Mathf.PI / 180;
            float omega2 = range2 * Mathf.PI / 180;
            Vector3 Rvector = new Vector3(Mathf.Cos(omega1), 0, Mathf.Sin(omega1)).normalized;
            Vector3 rvector = (Rvector * Mathf.Cos(omega2)+new Vector3(0,Mathf.Sin(omega2),0)).normalized;
            Vector3 toward = Vector3.Cross(Vector3.up, Rvector).normalized;
            Vector3 upward = -rvector;
            Quaternion rotate =Quaternion.LookRotation(toward,upward);
            GameObject obj=Instantiate(Road,Rcenter+R*Rvector+(r+Random.Range(-r+1,0))*rvector,rotate);
            obj.transform.parent = transform;
            range1 += range1delta;
            range2 += Random.Range(0,360f);
        }
    }
}
