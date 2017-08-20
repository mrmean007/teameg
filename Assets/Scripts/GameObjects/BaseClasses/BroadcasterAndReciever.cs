using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class BroadcasterAndReciever : MonoBehaviour
{
	public EventManager EventSys { get { return EventManager.Instance; } }


	public GameSessionManager GameSession { get { return GameSessionManager.Instance; } }



  

 

	protected virtual void Start ()
	{
		SubscribeToEvents ();
	}

	protected virtual void SubscribeToEvents ()
	{
	}
}

public abstract class BroadcasterAndRecieverSingletonPersistent<T> : UnitySingletonPersistent<T> where T : MonoBehaviour
{
	public EventManager EventSys { get { return EventManager.Instance; } }



  
	protected virtual void Start ()
	{
		SubscribeToEvents ();
		SceneManager.sceneLoaded += delegate(Scene arg0, LoadSceneMode mode) {
			SubscribeToEvents ();
		};
	}

	protected virtual void SubscribeToEvents ()
	{
	}
}

public abstract class BroadcasterAndRecieverSingleton<T> : UnitySingleton<T> where T : MonoBehaviour
{
	public EventManager EventSys { get { return EventManager.Instance; } }


	protected virtual void Start ()
	{
		SubscribeToEvents ();
	}

	protected virtual void SubscribeToEvents ()
	{
	}
}