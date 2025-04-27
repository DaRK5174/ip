using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public Slider sliderVolumeMusic;
    public AudioSource audio;
    public float volume;
    public Toggle toggleMusic;
    void Start()
    {
        //Load();
        ValueMusic();
    }
    public void SliderMusic()
    {
        volume = sliderVolumeMusic.value;
        //Save();
        ValueMusic();
    }
    public void ValueMusic()
    {
        audio.volume = volume;
        sliderVolumeMusic.value = volume;
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
