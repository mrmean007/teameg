using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : BroadcasterAndRecieverSingletonPersistent<SFXManager>
{
	private AudioSource _audioSource;

	protected override void Start ()
	{
		base.Start ();
		_audioSource = GetComponent<AudioSource> ();
	}

	protected override void SubscribeToEvents ()
	{
		base.SubscribeToEvents ();
     
	}
}
