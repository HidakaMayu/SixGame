using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    [SerializeField] Text text;
    Days day = Days.Eight;
    public Days Days
    {
        get => day;
        set
        {
            Debug.Log(35);
            value = (Days)Player.stage;
            Days = value;
            OnCellStateChanged();
        }
    }
    void Start()
    {
        OnCellStateChanged();
        //player‚Ì‰ï˜b•¶‚ğ®”õ
        Debug.Log(12);
    }
    private void Update()
    {
        day = (Days)Player.stage;
    }

    private void OnCellStateChanged()
    {
        text.text = day.ToString();
    }
}
public enum Days{
    One = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
}