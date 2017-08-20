using System;
using UnityEngine;

public class QuitGameMenu : UIAnimatedWindow
{

	protected override void SubscribeToEvents ()
	{
		base.SubscribeToEvents ();
       
	}

	public void Yes ()
	{
	}

	public void No ()
	{
		CloseWindow ();
	}
}
