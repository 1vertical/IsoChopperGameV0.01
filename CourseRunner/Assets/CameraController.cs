using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform CamTarget;
    public Transform PlayerPos;
    public Vector3 CamOffset;
    

    // Use this for initialization
	void Start () {
//        CamOffset = new Vector3(10, 25, -3);
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(CamTarget.position);
    }
}
