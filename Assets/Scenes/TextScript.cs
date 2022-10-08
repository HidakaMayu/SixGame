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
        //    text.text = "少女と思考実験\nもうすぐ終わりが近づいてくる\nこれは私の直感。そう。終わるの。";
        //}
        //else if (Player.stage == 9)
        //{
        //    text.text = "少女と思考実験\nこの終わりが次のループへとつながっていることを\n私は知っている。";
        //}
    }
}
