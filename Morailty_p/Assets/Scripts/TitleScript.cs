using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public void NextScene()
    { // mainScene���� �Ѿ��
        SceneManager.LoadScene("FirstScene");
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
