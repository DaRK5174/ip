using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPad : MonoBehaviour
{
    private Animator anim1;
    void Start()
    {
        anim1 = GetComponent<Animator>();
    }

    public void onSetting()
    {
        anim1.SetTrigger("Setting");
    }
}
