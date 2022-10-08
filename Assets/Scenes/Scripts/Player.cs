using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using Unity.VisualScripting;
using System.Drawing;
using System.Net.Sockets;

public class Player : MonoBehaviour
{
    Rigidbody _rb = default;
    [SerializeField] float speed = 4.0f;
    float wSpeed;
    [SerializeField]List<GameObject> item = new List<GameObject>();
    [SerializeField]GameObject player = null;
    [SerializeField] GameObject[] doors = {};
    //[SerializeField] GameObject dooor = null;

    //鍵がかかってる場所
    [SerializeField] Text rocked = default;

    //ドア音
    //[SerializeField] AudioClip dse; 
    //AudioSource audioSource;

    public static bool trigger = false;
    int random;
    float h,v;
    public static int stage = 1;
    [SerializeField] Text nowRoom;

    //フェード
    [SerializeField] public GameObject panel;
    GameObject door;
    Image fadeImage;
    float fadeSpeed = 0.02f;
    float fade;
    float time;

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
        fadeImage = panel.GetComponent<Image>();
        fade = fadeImage.color.a;
        //audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        Vector3 dir = Vector3.forward * v + Vector3.right * h;
        _rb.velocity = dir.normalized * speed;
        nowRoom.text = $"room_No.{stage}";
    }
    private void OnTriggerEnter(Collider collision)
    {
        //audioSource.PlayOneShot(door);
        if (collision.gameObject.CompareTag("Dor"))　　
        {
            if (stage == 7)
            {
                SceneManager.LoadScene("Title");
            }
            rocked = default;
            trigger = true; Debug.Log(trigger);
            //audioSource.PlayOneShot(dse);
            fadeImage.DOFade(endValue: 250f, duration: 1f);
            StartCoroutine(OneCushion());
            fadeImage.DOFade(endValue: 0f, duration: 3f);
            player.SetActive(true);
            speed = wSpeed;
            door = null;
        }
        else if(collision.gameObject.CompareTag("Rocked"))
        {
            rocked.text = "鍵がかかっている";
        }
        
    }
    //void OnTriggerExit(Collider other)
    //{
    //    dooor.SetActive(true);
    //}

    IEnumerator OneCushion()
    {
        Debug.Log(4);
        //fadeImage.color = new Color(0, 0, 0, fade);
        //if (fade >= 255) fade += fadeSpeed;Debug.Log(5);
        int randomd = Random.Range(0, 4);
        if(door == null)
        {
            door = doors[randomd];
            this.transform.position = door.transform.position - Vector3.down;
        }
        wSpeed = speed;
        speed = 0;
        //dooor.SetActive(false);
        player.SetActive(false);
        foreach (GameObject go in item)
        {
            int random = Random.Range(0, 10);
            if (random > 6 && Item.get == false) { go.SetActive(true); Debug.Log("true"); }
            else if (random <= 0) { go.SetActive(false); Debug.Log("false"); }
            Debug.Log(random);
        }
        stage++;
        Debug.Log("open");//部屋リセット＆もう一つのドアへ（移動がわかるように、ドアの音＆一瞬暗転でその間に家具リセット）
        trigger = false; Debug.Log(trigger);
        yield return new WaitForSeconds(5.0f);Debug.Log(6);
        //if (fade <= 1) fade -= fadeSpeed; fadeImage.color = new Color(255, 255, 255, fade);
    }
}
