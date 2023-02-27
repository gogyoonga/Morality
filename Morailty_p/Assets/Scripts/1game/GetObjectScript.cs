using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class GetObjectScript : MonoBehaviour
{

    // Curtain
    public GameObject curtainDrawnObject;
    public GameObject curtainOpenObject;
    // Statue Box
    public GameObject statueBoxCloseObject;
    public GameObject statueBoxOpenObject;
    //

    Vector3 m_vecMouseDownPos;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_vecMouseDownPos = Input.mousePosition;
            // 마우스 클릭 위치를 카메라 스크린 월드포인트로 변경
            Vector2 pos = Camera.main.ScreenToWorldPoint(m_vecMouseDownPos);
            // Raycase함수를 통해 부딪치는 collider를 hit에 리턴
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null) {
                Debug.Log(hit.collider.name);

                if (hit.collider.name == "open_curtain")
                {
                    Debug.Log("open_curtain Hit");
                    curtainDrawnObject.gameObject.SetActive(true);
                    curtainOpenObject.gameObject.SetActive(false);
                }
                else if (hit.collider.name == "drawn_curtain")
                {
                    Debug.Log("drawn_curtain Hit");
                    curtainDrawnObject.gameObject.SetActive(false);
                    curtainOpenObject.gameObject.SetActive(true);
                }
                else if (hit.collider.name == "statuesBox_open")
                {
                    Debug.Log("open_box Hit");
                    statueBoxCloseObject.gameObject.SetActive(true);
                    statueBoxOpenObject.gameObject.SetActive(false);
                }
                else if (hit.collider.name == "statuesBox_close")
                {
                    Debug.Log("close_box Hit");
                    statueBoxCloseObject.gameObject.SetActive(false);
                    statueBoxOpenObject.gameObject.SetActive(true);
                }
            }
        }
    }
}