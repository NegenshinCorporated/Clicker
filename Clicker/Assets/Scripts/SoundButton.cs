using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Sprite audioOff;
    public Sprite audioOn;
    public GameObject buttonAudio;
    public AudioClip clip;
    public AudioSource audioS;
    public void OnOffAudio()
    {
        if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            audioOff = buttonAudio.GetComponent<Image>().sprite;
        }
        else
        {
            AudioListener.volume = 1;
            audioOn = buttonAudio.GetComponent<Image>().sprite;
        }
    }
}
