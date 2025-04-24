using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    public Slider sliderVolumeMusic2;
    public AudioSource audio;
    public float volume2;
    public Toggle toggleMusic;
    void Start()
    {
        //Load();
        ValueMusic2();
    }
    public void SliderMusic2()
    {
        volume2 = sliderVolumeMusic2.value;
        //Save();
        ValueMusic2();
    }
    public void ValueMusic2()
    {
        audio.volume = volume2;
        sliderVolumeMusic2.value = volume2;
        //if (volume == 0){toggleMusic.isOn = false;} else {toggleMusic.isOn = true;}
    }

    //public void Save()
    //{
    //    PlayerPrefs.SetFloat("volume", volume);
    //}

    //private void Load()
    //{
    //    volume = PlayerPrefs.GetFloat("volume", volume)
    //}
}

