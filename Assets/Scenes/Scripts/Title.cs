using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Title : MonoBehaviour
{
    //[SerializeField] Material material;
    //public float DurationSeconds;
    //public Ease EaseType;
    // Start is called before the first frame update
    void Start()
    {
        Player.stage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //ç∂É{É^Éì
        {
            SceneManager.LoadScene("GameScene");
        }

        //material.DOFade(0.0f, 1.0f).SetLoops(-1, LoopType.Yoyo);
    }
   
}
