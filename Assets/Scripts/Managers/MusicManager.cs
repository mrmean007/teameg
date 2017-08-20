using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : BroadcasterAndRecieverSingletonPersistent<MusicManager>
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

	void PlayMusic (AudioClip musicFile)
	{
		_audioSource.clip = musicFile;
		_audioSource.Play ();
	}

	void StopMusic ()
	{
		_audioSource.Stop ();
	}
}
