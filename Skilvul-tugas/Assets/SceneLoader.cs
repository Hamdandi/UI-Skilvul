using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // public Sprite[] spriteMute;
    // public Button buttonMute;

    // public void Start()
    // {
    //     Screen.SetResolution(1920, 1080, true);
    // }

    public void LoadScene(int scaneIndex)
    {
        SceneManager.LoadScene(scaneIndex);

        Debug.Log("Load Scene " + scaneIndex);
    }
    // public void ButtonMute()
    // {
    //    if (AudioManager.In
    // }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Akhirnya Selesai, maaf masih gk sempurna masih ada Error hehe " + Application.productName);
    }
}
