using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPad : MonoBehaviour
{
    private bool paus=true;
    private Animator anim1;
    public PlayGame_Tea PlayGame_tea;
    void Start()
    {
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
}
