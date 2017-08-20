using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class GameStateManager : BroadcasterAndRecieverSingletonPersistent<GameStateManager>
{
	private Scene _currentScene;

	protected override void Start ()
	{
		base.Start ();
		Application.targetFrameRate = 60;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		SceneManager.LoadScene (1);
	}

	protected override void SubscribeToEvents ()
	{
     
       
      
	}

	void RestartGame ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex, LoadSceneMode.Single);
		Time.timeScale = 1;
	}

	private void OnSwitchScene ()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene ("GamePlay");

	}

	private void OnLose ()
	{
		Time.timeScale = 0;
	}

	public void ExitApplication ()
	{
		Application.Quit ();
	}
}