using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindow : BroadcasterAndReciever
{
	public virtual void OpenWindow ()
	{
		gameObject.SetActive (true);
	}

	public virtual void CloseWindow ()
	{
		gameObject.SetActive (false);
	}

	protected override void SubscribeToEvents ()
	{
		base.SubscribeToEvents ();
    
	}
}
