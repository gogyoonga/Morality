using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLogoScript : MonoBehaviour
{
    public void NextScene()
    { // mainScene���� �Ѿ��
        SceneManager.LoadScene("TitleScene");
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