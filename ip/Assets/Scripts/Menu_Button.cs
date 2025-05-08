using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Button : MonoBehaviour
{
    public string sceneName;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnClickPlay()
    {
        SceneManager.LoadScene(sceneName);
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
}