using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    [SerializeField] Text text;
    void Start()
    {
        //player�̉�b���𐮔�
        Debug.Log(12);
    }
    private void Update()
    {
        switch(Player.stage)
        {
            case 0:
            case 1:
            case 2:
            case 3: 
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                text.text = $"{Player.stage}��ڂ̃��[�v�ł��B";
            break;
                

        }
    }
}