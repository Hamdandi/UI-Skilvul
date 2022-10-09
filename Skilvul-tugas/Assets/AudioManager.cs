using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider BGMSlider;
    public Slider SFXSlider;
    public AudioMixer mixer;

    [SerializeField] Toggle muteToggle;

    private void Start()
    {
        float db;

        if (mixer.GetFloat("BGM_VOL", out db))
            BGMSlider.value = (db + 80) / 80;

        if (mixer.GetFloat("SFX_VOL", out db))
            SFXSlider.value = (db + 80) / 80;

    }

    public void BGMVolume(float value)
    {
        value = value * 80 - 80;

        mixer.SetFloat("BGM_VOL", value);

        Debug.Log("BGM Volume: " + value);
    }
    public void SFXVolume(float value)
    {
        value = value * 80 - 80;

        mixer.SetFloat("SFX_VOL", value);

        Debug.Log("SFX Volume: " + value);
    }

    public void Mute()
    {
        if (muteToggle.isOn == true)
        {
            mixer.SetFloat("BGM_VOL", -80);
            mixer.SetFloat("SFX_VOL", -80);
        }
        else
        {
            mixer.SetFloat("BGM_VOL", 0);
            mixer.SetFloat("SFX_VOL", 0);
        }

        Debug.Log("now is mute " + muteToggle.isOn);
    }

}
