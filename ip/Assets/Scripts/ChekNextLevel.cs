using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChekNextLevel : MonoBehaviour
{
    int LevelUnlock;
    public Button[] menu_Buttons;
    private Animator anim;
    void Start()
    {
        LevelUnlock = PlayerPrefs.GetInt("Levels", 1);
        anim = GetComponent<Animator>();

        for(int i = 0; i < menu_Buttons.Length; i++)
        {
            menu_Buttons[i].interactable = false;
        }

        for (int i = 0; i < LevelUnlock; i++)
        {
            menu_Buttons[i].interactable = true;
        }
    }

    public void LoadLevel(int LevelIndex)
    {
        anim.SetTrigger("NewLevel");
        //SceneManager.LoadScene(LevelIndex);
    }
}
