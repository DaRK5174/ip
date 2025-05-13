using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : ChekNextLevel
{
    public static bool win = false;
    private Animator anim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        win = true;
        menu_Buttons[2].interactable = true;
    }

    void Start()
    {
    }
}
