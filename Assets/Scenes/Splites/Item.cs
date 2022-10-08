using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    bool lookAway = false;
    [SerializeField] Text text;
    public static bool get = false;

    public KeyCode Y { get; private set; }

    // Start is called before the first frame update
    private void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(1);
        text.text = $"{this.name}ÇæÅBèEÇ¢Ç‹Ç∑Ç©ÅH\nYes(Y)  No(N)";
        if(Input.GetKeyDown(Y))
        {
            this.gameObject.SetActive(false);
            text.text = $"{this.name}ÇèEÇ¡ÇΩ";
            get = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Invoke(nameof(stopText), 2.5f);
        }
    }
    void stopText()
    {
        text.text = " ";
    }
    // Update is called once per frame
}
