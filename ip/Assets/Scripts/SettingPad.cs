using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPad : PlayGame
{
    private bool paus=true;
    private Animator anim1;
    public PlayGame_Tea PlayGame_tea;
    private int wincheck = 0;
    void Start()
    {
        bool win = PlayGame.win;
        anim1 = GetComponent<Animator>();
    }

    public void onSetting()
    {
        Paus();
        anim1.SetTrigger("Setting");
    }
    public void Paus()
    {
        if (paus == true)
        {
            Time.timeScale = 0;
            paus = false;
        }
        else
        {
            Time.timeScale = 1;
            paus = true;
        }
    }

    private void Update()
    {
        if (win == true && wincheck==0)
        {
            
            wincheck = 1;
            anim1.SetTrigger("Win");

        }
    }
}
