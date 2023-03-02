using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class WorkBenchScript : MonoBehaviour
{
    public GameObject workLeftOpen;
    public GameObject workRightOpen;


    private bool workLeft = false; // T == open F == close
    private bool workRight = false;

    Vector3 m_vecMouseDownPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_vecMouseDownPos = Input.mousePosition;
            // ���콺 Ŭ�� ��ġ�� ī�޶� ��ũ�� ��������Ʈ�� ����
            Vector2 pos = Camera.main.ScreenToWorldPoint(m_vecMouseDownPos);
            // Raycase�Լ��� ���� �ε�ġ�� collider�� hit�� ����
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);

                if (hit.collider.name == "workbench_L")
                {
                    if (workLeft)
                    
                        workLeft = false;
                        
                   
                    else
                        workLeft = true;

                    workLeftOpen.gameObject.SetActive(true);

                }
                else if (hit.collider.name == "workbench_R")
                {
                    if (workRight)
                        workRight = false;
                    else
                        workRight = true;

                    workRightOpen.gameObject.SetActive(true);
                }
                else if (hit.collider.name == "workDesk_left")
                {
                    workLeftOpen.gameObject.SetActive(false);
                }
                else if (hit.collider.name == "workDesk_right")
                {
                    workRightOpen.gameObject.SetActive(false);
                }
            }

            

          

        } 
    }
}
