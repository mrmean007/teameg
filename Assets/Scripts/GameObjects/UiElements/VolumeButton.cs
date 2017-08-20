using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class VolumeButton : BroadcasterAndReciever {

    public Sprite VolumeOn, VolumeOff;
    public bool IsVolumeOn;
    protected override void SubscribeToEvents()
    {
        base.SubscribeToEvents();
        GetComponent<Button>().onClick.AddListener(delegate
        {
            if (IsVolumeOn)
            {
                StopSFx();
            }
            else
            {
                PlaySfx();
            }
        });

    }

    void PlaySfx()
    {
        IsVolumeOn = true;
        gameObject.GetComponent<Image>().sprite = VolumeOn;
    }

    void StopSFx()
    {
        IsVolumeOn = false;
        gameObject.GetComponent<Image>().sprite = VolumeOff;

    }
}
