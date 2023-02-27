using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public void NextScene()
    { // mainScene으로 넘어가기
        SceneManager.LoadScene("FirstScene");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        { // 마우스 왼쪽 버튼을 누르면
            NextScene();
        }

    }
}
