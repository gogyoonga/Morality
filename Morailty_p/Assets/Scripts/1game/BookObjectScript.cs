using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BookObjectScript : MonoBehaviour
{
    public GameObject bookObjectOne;
    public GameObject bookObjectTwo;
    public GameObject bookObjectThree;
    public GameObject bookObjectFour;
    public GameObject bookObjectOne_;
    public GameObject bookObjectTwo_;
    public GameObject bookObjectThree_;
    public GameObject bookObjectFour_;

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

                if (hit.collider.name == "book1")
                {
                    Debug.Log("book1 Hit");
                    bookObjectOne_.gameObject.SetActive(true);
                    bookObjectOne.gameObject.SetActive(false);
                }
                else if(hit.collider.name == "book1_1")
                {
                    bookObjectOne.gameObject.SetActive(true);
                    bookObjectOne_.gameObject.SetActive(false);
                }
                else if (hit.collider.name == "book2")
                {
                    Debug.Log("book2 Hit");
                    bookObjectTwo_.gameObject.SetActive(true);
                    bookObjectTwo.gameObject.SetActive(false);
                }
                else if (hit.collider.name == "book2_1")
                {
                    bookObjectTwo.gameObject.SetActive(true);
                    bookObjectTwo_.gameObject.SetActive(false);
                }
                else if (hit.collider.name == "book3")
                {
                    bookObjectThree_.gameObject.SetActive(true);
                    bookObjectThree.gameObject.SetActive(false);
                }
                else if (hit.collider.name == "book3_1")
                {
                    bookObjectThree.gameObject.SetActive(true);
                    bookObjectThree_.gameObject.SetActive(false);
                }
                else if (hit.collider.name == "book4")
                {
                    Debug.Log("book4 Hit");
                    bookObjectFour_.gameObject.SetActive(true);
                    bookObjectFour.gameObject.SetActive(false);
                }
                else if (hit.collider.name == "book4_1")
                {
                    bookObjectFour.gameObject.SetActive(true);
                    bookObjectFour_.gameObject.SetActive(false);
                }
            }
        }
    }
}
