using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CurtainScript : MonoBehaviour
{   
    

    public GameObject curtainDrawnObject;
    public GameObject curtainOpenObject;
    private bool state;
    // Start is called before the first frame update
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          
            if (state == true)
            {
                curtainDrawnObject.gameObject.SetActive(true);
                curtainOpenObject.gameObject.SetActive(false);
                state = false;
            }
            else
            {
                curtainDrawnObject.gameObject.SetActive(false);
                curtainOpenObject.gameObject.SetActive(true);
                state = true;
            }
        }
    }
}
