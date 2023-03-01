using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BedObjectScript : MonoBehaviour
{
    public GameObject cleanBeddingObject;
    public GameObject messyBeddingObject;

    public GameObject pinoLowBody;

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

                if (hit.collider.name == "bedding")
                {
                    Debug.Log("bedding Hit");
                    cleanBeddingObject.gameObject.SetActive(false);
                    messyBeddingObject.gameObject.SetActive(true);
                }
                else if (hit.collider.name == "bedding_messy")
                {
                    Debug.Log("messy bedding Hit");
                    cleanBeddingObject.gameObject.SetActive(true);
                    messyBeddingObject.gameObject.SetActive(false);
                }
                else if (hit.collider.name == "beddingM_pinoLowBody")
                {
                    Debug.Log("pinoLowBody Hit");
                    pinoLowBody.gameObject.SetActive(false);
                }
            }
        }
    }
}
