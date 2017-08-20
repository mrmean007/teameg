using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class MusicButton : BroadcasterAndReciever
{
    public Sprite MusicOn, MusicOff;
    public bool IsMusicPlaying;
    protected override void SubscribeToEvents()
    {
        base.SubscribeToEvents();
        GetComponent<Button>().onClick.AddListener(delegate
        {
            if (IsMusicPlaying)
            {
                StopMusic();

            }
            else
            {
                PlayMusic();

            }
        });
        
    }

    void PlayMusic()
    {
        IsMusicPlaying = true;
        gameObject.GetComponent<Image>().sprite = MusicOn;
    }

    void StopMusic()
    {
        IsMusicPlaying = false;
        gameObject.GetComponent<Image>().sprite = MusicOff;
        
    }
}
