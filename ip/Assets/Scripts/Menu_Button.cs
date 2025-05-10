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
        SceneManager.LoadScene(sceneName[0]);
    }

    public void OnClickRepit()
    {
        SceneManager.LoadScene(sceneName[1]);
    }

    public void OnClickNext()
    {
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