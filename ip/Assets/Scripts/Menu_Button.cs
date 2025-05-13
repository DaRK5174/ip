using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Button : MonoBehaviour
{
    public string[] sceneName;
    private Animator anim;
    

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnClickPlay()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        SceneManager.LoadScene(sceneName[0]);
    }

    public void OnClickRepit()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        SceneManager.LoadScene(sceneName[1]);
    }

    public void OnClickNext()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        SceneManager.LoadScene(sceneName[2]);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void Perehod()
    {
        anim.SetTrigger("Scene");
        anim.SetTrigger("NewLevel");
    }
    public void PerehodRepit()
    {
        anim.SetTrigger("Repit");
    }
    public void PerehodNext()
    {
        anim.SetTrigger("Next");
    }
}