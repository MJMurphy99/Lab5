using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

    public void GoToLevel()
    {
        SceneManager.LoadScene("SampleScene 1");
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("SampleScene 2");
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene("SampleScene 3");
    }

    public void GoToLevel4()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
