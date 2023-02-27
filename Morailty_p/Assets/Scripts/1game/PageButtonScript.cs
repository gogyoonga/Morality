using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageButtonScript : MonoBehaviour
{

    public void bedRoom()
    {
        SceneManager.LoadScene("FirstTwoGameScene");
        Debug.Log("hit");
    }
    public void livingRoom()
    {
        SceneManager.LoadScene("FirstGameScene");
    }
    public void workRoom()
    {
        SceneManager.LoadScene("FirstThreeGameScene");
    }
}
