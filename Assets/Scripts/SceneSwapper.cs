using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneSwapper : MonoBehaviour
{
    public void onClickMenu()
    {
        SceneManager.LoadScene("Title Screen");
    }
    public void onClickPlay()
    {
        SceneManager.LoadScene("Map");
    }
    public void onClickQiut()
    {
        Application.Quit();
    }
}
