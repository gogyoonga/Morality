using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class workChairScript : MonoBehaviour
{
    public GameObject workChairIn; 
    public GameObject workChairOut;
    private bool state = false; //in

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(state == true) //out
            {
                workChairIn.gameObject.SetActive(false);
                workChairOut.gameObject.SetActive(true);
                state = false; //in
            }
            else
            {
                workChairIn.gameObject.SetActive(true);
                workChairOut.gameObject.SetActive(false);
                state = true; //out
            }
        }
    }
}
