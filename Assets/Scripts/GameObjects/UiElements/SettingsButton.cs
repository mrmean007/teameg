using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class SettingsButton : BroadcasterAndReciever
{

    public bool IsSettingTriggered = false;
    public float SpeedEffect = 2.0f;
    protected override void SubscribeToEvents()
    {
        base.SubscribeToEvents();
        GetComponent<Button>().onClick.AddListener(delegate
        {
            if (!IsSettingTriggered)
            {
                PopOutSettingButtons();
                IsSettingTriggered = true;
            }
            else
            {
                PopInSettingButtons();
                IsSettingTriggered = false;
            }
        });
    }
    public void PopOutSettingButtons()
    {
        StartCoroutine(AnimateSetting());
    }
    IEnumerator AnimateSetting()
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
    public void PopInSettingButtons()
    {
        StartCoroutine(DeanimateSetting());
    }
    IEnumerator DeanimateSetting()
    {
        int children = transform.childCount;
        for (int i = children - 1; i >= 0; --i)
        {
            Transform child = transform.GetChild(i);
            GameObject obj = child.gameObject;
            obj.SetActive(false);
            yield return new WaitForSeconds(SpeedEffect);
        }
    }
}
