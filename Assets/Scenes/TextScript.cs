using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    [SerializeField] Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.stage == 1)
        {
            text.text = "a\no";
        }
        else if(Player.stage == 2)
        {
            text.text = "a\no";
        }
        else if (Player.stage == 3)
        {
            text.text = "a\no";
        }
        else if (Player.stage == 4)
        {
            text.text = "a\no";
        }
        else if (Player.stage == 5)
        {
            text.text = "a\no";
        }
        else if (Player.stage == 6)
        {
            text.text = "a\no";
        }
        else if (Player.stage == 7)
        {
            text.text = "a\no";
        }
        //else if (Player.stage == 8)
        //{
        //    text.text = "�����Ǝv�l����\n���������I��肪�߂Â��Ă���\n����͎��̒����B�����B�I���́B";
        //}
        //else if (Player.stage == 9)
        //{
        //    text.text = "�����Ǝv�l����\n���̏I��肪���̃��[�v�ւƂȂ����Ă��邱�Ƃ�\n���͒m���Ă���B";
        //}
    }
}
