using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class No1_1Script : MonoBehaviour
{
    public void NextScene()
    { // mainScene���� �Ѿ��
        SceneManager.LoadScene("No1_2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // ���콺 ���� ��ư�� ������
            NextScene();
        }
    }
}