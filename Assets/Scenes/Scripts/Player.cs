using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Player : MonoBehaviour
{
    Rigidbody2D _rb = null;
    [SerializeField] float speed = 4.0f;
    float wSpeed;
    [SerializeField]List<GameObject> item = new List<GameObject>();
    [SerializeField]GameObject player = null;


    //ドア音
    [SerializeField] AudioClip door; 
    AudioSource audioSource;

    public static bool trigger = false;
    int random;
    float h;
    [SerializeField] int stage = 1;
    [SerializeField] Text nowRoom;

    //フェード
    [SerializeField] public GameObject panel;
    Image fadeImage;
    float fadeSpeed = 0.02f;
    float fade;
    List<Image> images;
    float time;

    void Start()
    {
        images = new List<Image>();
        _rb = this.GetComponent<Rigidbody2D>();
        fadeImage = panel.GetComponent<Image>();
        fade = fadeImage.color.a;
        images.Add(GameObject.Find("Image").GetComponent<Image>());
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
         h = Input.GetAxis("Horizontal") * speed;
        _rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, _rb.velocity.y);
        time = Time.deltaTime;
        nowRoom.text = $"No.{stage}";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //audioSource.PlayOneShot(door);
        if (collision.gameObject.CompareTag("Door"))　　
        {
            trigger = true; Debug.Log(trigger);
            audioSource.PlayOneShot(door);
            fadeImage.DOFade(endValue: 250f, duration: 1f);
            StartCoroutine(OneCushion());
            fadeImage.DOFade(endValue: 0f, duration: 3f);
            player.SetActive(true);
            speed = wSpeed;
        }
        
    }
    void NextStage()
    {/*
        fade += fadeSpeed;
        if (fade >= 1)
        {*/
        //fadeImage.color = new Color(255, 255, 255, fade);
        //foreach (Image go in item)
        //{
        //    random = Random.Range(0, 10);
        //    if (random > 6) { go.enabled = true; Debug.Log("true"); }
        //    else if(random <= 0) { go.enabled = false; Debug.Log("false"); }
        //    Debug.Log(random);
        //}
        //transform.position = new Vector3(-6.5f, -2.52f, -2f);
        //次の部屋へ移動してから数時増える
        //this.gameObject.SetActive(false);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //stage++;
        //Debug.Log("open");//部屋リセット＆もう一つのドアへ（移動がわかるように、ドアの音＆一瞬暗転でその間に家具リセット）
        //trigger = false;Debug.Log(trigger);
         /*   fade -= fadeSpeed;
        }
         */
        
    }
    IEnumerator OneCushion()
    {
        Debug.Log(4);
        //fadeImage.color = new Color(0, 0, 0, fade);
        //if (fade >= 255) fade += fadeSpeed;Debug.Log(5);
        this.transform.position = new Vector3(-7.0f, -2.52f, -2f);
        wSpeed = speed;
        speed = 0;
        player.SetActive(false);
        foreach (GameObject go in item)
        {
            random = Random.Range(0, 10);
            if (random > 6) { go.SetActive(true); Debug.Log("true"); }
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
