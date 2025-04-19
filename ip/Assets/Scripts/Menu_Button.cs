using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Button : MonoBehaviour
{
    public string sceneName;
    public void OnClickPlay()
    {
        SceneManager.LoadScene(sceneName);
    }
   
    public void OnClickExit()
    {
        SceneManager.LoadScene(sceneName);
    }
}