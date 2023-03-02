using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class chestObjectScript : MonoBehaviour

   
{
    public GameObject chestTopBottomOpen;
    public GameObject chestTopOpen;
    public GameObject chestBottomOpen;
   

    private bool chestTop = false; // T == open F == close
    private bool chestBottom = false;

    public GameObject candle;
    public GameObject candleLighten;


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

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);

                if (hit.collider.name == "chest_top")
                {
                    if (chestTop)
                        chestTop = false;
                    else
                        chestTop = true;
                }
                else if (hit.collider.name == "chest_bottom")
                {
                    if (chestBottom)
                        chestBottom = false;
                    else
                        chestBottom = true;
                }
            }


            if (chestTop && !chestBottom)
            {
                chestTopBottomOpen.gameObject.SetActive(false);
                chestTopOpen.gameObject.SetActive(true);
                chestBottomOpen.gameObject.SetActive(false);
            }
            else if (chestTop && chestBottom)
            {
                chestTopBottomOpen.gameObject.SetActive(true);
                chestTopOpen.gameObject.SetActive(false);
                chestBottomOpen.gameObject.SetActive(false);

            }
            else if (!chestTop && chestBottom)
            {
                chestTopBottomOpen.gameObject.SetActive(false);
                chestTopOpen.gameObject.SetActive(false);
                chestBottomOpen.gameObject.SetActive(true);
            }
            else if(!chestTop && !chestBottom)
            {
                chestTopBottomOpen.gameObject.SetActive(false);
                chestTopOpen.gameObject.SetActive(false);
                chestBottomOpen.gameObject.SetActive(false);
            }

        }
    }
}
