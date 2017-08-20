using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNotification : BroadcasterAndReciever
{

	[SerializeField]
	private Animator _animator;

	public string AnimationTrigger;
	public Text TextBox;

	protected override void Start ()
	{
		_animator = GetComponent<Animator> ();
		SubscribeToEvents ();
	}

	new void SubscribeToEvents ()
	{
      
	}

	public void OpenWindow (string notificationText)
	{
		_animator.SetTrigger (AnimationTrigger);
		TextBox.text = notificationText;
	}

}
