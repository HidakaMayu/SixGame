using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    float pSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        SceneManager.LoadScene("Title");
    }
    public void ClickSave()
    {
        Debug.Log("ÉfÅ[É^Çï€ë∂ÇµÇ‹ÇµÇΩ");
    }
}
