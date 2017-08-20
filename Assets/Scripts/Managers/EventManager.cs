
using System;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : UnitySingleton<EventManager>
{
   


	private void Start ()
	{
      
	}


}

[Serializable]
public class FloatEvent : UnityEvent<float>
{

}

[Serializable]
public class StringEvent : UnityEvent<string>
{

}

[Serializable]
public class IntEvent : UnityEvent<int>
{

}

