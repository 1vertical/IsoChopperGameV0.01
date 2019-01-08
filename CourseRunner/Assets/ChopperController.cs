using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopperController : MonoBehaviour {

    public GameObject targetingRect;
    public Transform chopperPos;
    public GameObject chopperLadder;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        #region LADDER
        if (Input.GetKeyUp(KeyCode.F))
        {
            if(chopperLadder.activeSelf == true)
            {
                chopperLadder.SetActive(false);
            }
            else
            {
                chopperLadder.SetActive(true);
            }
            
        }
        #endregion

        #region STRAFING
        if (Input.GetKey(KeyCode.E))
        {
            chopperPos.transform.Translate(0.5f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            chopperPos.transform.Translate(-0.5f, 0, 0);
        }
        #endregion

        #region FORWARD/BACK
        if (Input.GetKey(KeyCode.W))
        {
            chopperPos.transform.Translate(0, 0, 0.5f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            chopperPos.transform.Translate(0, 0, -0.5f);
        }
        #endregion


        #region TURNING
        if (Input.GetKey(KeyCode.D))
        {
            chopperPos.transform.Rotate(0, 2f, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            chopperPos.transform.Rotate(0, -2f, 0);
        }
        #endregion

        #region TEMPLATE

        #endregion


    }
}
