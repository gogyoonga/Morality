using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainScript : MonoBehaviour
{
    public void NextScene()
    { // mainScene���� �Ѿ��
        SceneManager.LoadScene("");
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
