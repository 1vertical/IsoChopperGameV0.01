using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorController : MonoBehaviour {

    public Vector3 m_RotatePower;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(m_RotatePower);
	}
}
