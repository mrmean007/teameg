using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFieldUpdater : BroadcasterAndReciever {

    [SerializeField]
    protected UnityEngine.UI.Text textBox;

    public virtual void Start()
    {
        textBox = GetComponent<Text>();
    }

    public void UpdateText(string newText)
    {
        if (textBox != null)
        {
            textBox.text = newText;
        }
    }

    public void UpdateText(int newText)
    {
        textBox.text = newText.ToString();
    }
    public void UpdateText(float newText)
    {
        textBox.text = newText.ToString();
    }
}
