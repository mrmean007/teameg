using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : BroadcasterAndReciever
{
	public void PlayButton ()
	{
		SceneManager.LoadScene ("GamePlay");
	}



	public void OnRestart ()
	{
	}

	public void YesButtonOnMainMenu ()
	{
		Application.Quit ();
	}

	public void OnPauseButton ()
	{
	}

	public void OnResume ()
	{
	}

	public void OnHome ()
	{
	}
}
