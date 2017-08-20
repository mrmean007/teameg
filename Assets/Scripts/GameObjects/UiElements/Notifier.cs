using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notifier : BroadcasterAndReciever
{
    [SerializeField] private Animator _animator;

    public Text TextBox;

    public string AnimationTrigger;

    protected override void Start()
    {
        base.Start();
        _animator = GetComponent<Animator>();
    }


    public void TriggerNotification(string notificationText)
    {
        _animator.SetTrigger(AnimationTrigger);
        TextBox.text = notificationText;
    }

    public void TriggerNotification(int notificationText)
    {
        _animator.SetTrigger(AnimationTrigger);
        TextBox.text = notificationText.ToString();
    }
    public void TriggerNotification(float notificationText)
    {
        _animator.SetTrigger(AnimationTrigger);
        TextBox.text = notificationText.ToString();
    }
}