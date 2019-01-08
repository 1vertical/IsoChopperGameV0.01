using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody m_RigidBody;
    private float dt;
    public float m_ForwardForce = 2000f;
    public float m_SidewaysForce = 500f;

	// Use this for initialization
	void Start () {
        dt = Time.deltaTime;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        m_RigidBody.AddForce(0, 0, m_ForwardForce * dt);

        if(Input.GetKey("d"))
        {
            m_RigidBody.AddForce(m_SidewaysForce * dt, 0, 0);
        }
        else if (Input.GetKey("a"))
        {
            m_RigidBody.AddForce(-m_SidewaysForce * dt, 0, 0);
        }

    }
}
