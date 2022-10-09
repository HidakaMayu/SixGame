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
    [SerializeField] Renderer exclamation = null; //ビックリマーク
    [SerializeField] GameObject player = null;

    public KeyCode Y { get; private set; }

    // Start is called before the first frame update
    private void Start()
    {
        //2Dと3Dで交わらない。ビックリマークが表示されない
        exclamation.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        exclamation.enabled = true;
        Debug.Log(1);
        text.text = $"{this.name}だ。拾いますか？\nYes(Y)  No(N)";
        if(Input.GetKeyDown(Y))
        {
            this.gameObject.SetActive(false);
            text.text = $"{this.name}を拾った";
            get = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        exclamation.enabled = false;
        text.text = " ";
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
    //プレイヤータグのオブジェクトが範囲内に入ったときビックリマークをtrueに
    //離れたらfalseに
}
