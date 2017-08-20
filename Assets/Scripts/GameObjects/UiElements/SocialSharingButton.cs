using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SocialSharingButton : BroadcasterAndReciever {

    public bool IsSettingTriggered = false;
    public float SpeedEffect = 2.0f;

    protected override void SubscribeToEvents()
    {
        base.SubscribeToEvents();
        GetComponent<Button>().onClick.AddListener(delegate
        {
            if (!IsSettingTriggered)
            {
                PopOutSocialSharingButtons();
                IsSettingTriggered = true;
            }
            else
            {
                PopInSocialSharingButtons();
                IsSettingTriggered = false;
            }

        });
    }

    public void PopOutSocialSharingButtons()
    {
        StartCoroutine(AnimateSocialSharing());
    }   
    IEnumerator AnimateSocialSharing()
    {
        int children = transform.childCount;
        for (int i = 0; i < children; ++i)
        {
            Transform child = transform.GetChild(i);
            GameObject obj = child.gameObject;
            obj.SetActive(true);
            yield return new WaitForSeconds(SpeedEffect);
        }
    }
    public void PopInSocialSharingButtons()
    {
        StartCoroutine(DeanimateSocialSharing());
    }
    IEnumerator DeanimateSocialSharing()
    {
        int children = transform.childCount;
        for (int i = children-1; i >= 0; --i)
        {
            Transform child = transform.GetChild(i);
            GameObject obj = child.gameObject;
            obj.SetActive(false);
            yield return new WaitForSeconds(SpeedEffect);
        }
    }
}
