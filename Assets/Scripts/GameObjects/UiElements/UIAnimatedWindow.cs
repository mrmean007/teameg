using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class UIAnimatedWindow : UIWindow
{
    [SerializeField]
    private Animator _animator;

    public bool AutoOpenOnStart;
  //  public bool IsLooped;
    public bool AutoClose;

    public string AnimTriggerOnOpen;
    public string AnimTriggerOnClose;
    public float AutoStopAfterSeconds = 3f;

    protected override void Start()
    {
        base.Start();
        _animator = GetComponent<Animator>();
        AnimationOnStart();
    }

    private void AnimationOnStart()
    {
        if (AutoOpenOnStart)
        {
            OpenWindow();
            StartAutoCloseProcess();
        }
    }

     void  StartAutoCloseProcess()
    {
         if (AutoClose)
         {
             StartCoroutine(AutoStop());
         }
    }
    IEnumerator AutoStop()
    {
        yield return new WaitForSeconds(AutoStopAfterSeconds);
        CloseWindow();
    }

    public override void OpenWindow()
    {
        if (AnimTriggerOnOpen != "") _animator.SetBool(AnimTriggerOnOpen,true);
        StartAutoCloseProcess();
    }

    public override void CloseWindow()
    {
        if (AnimTriggerOnClose != "") _animator.SetBool(AnimTriggerOnClose,false);
    }
}

