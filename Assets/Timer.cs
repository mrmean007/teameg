using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
    public static float TimeLeft =60f;

    public static bool isGameOver;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TimeLeft -= Time.deltaTime;

        GetComponent<Text>().text = Mathf.Round(TimeLeft).ToString();

        if (TimeLeft < 0)
        {
            isGameOver = true;
        }

	}
}
