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
    [SerializeField] Renderer exclamation = null; //�r�b�N���}�[�N
    [SerializeField] GameObject player = null;

    public KeyCode Y { get; private set; }

    // Start is called before the first frame update
    private void Start()
    {
        //2D��3D�Ō����Ȃ��B�r�b�N���}�[�N���\������Ȃ�
        exclamation.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        exclamation.enabled = true;
        Debug.Log(1);
        text.text = $"{this.name}���B�E���܂����H\nYes(Y)  No(N)";
        if(Input.GetKeyDown(Y))
        {
            this.gameObject.SetActive(false);
            text.text = $"{this.name}���E����";
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
    //�v���C���[�^�O�̃I�u�W�F�N�g���͈͓��ɓ������Ƃ��r�b�N���}�[�N��true��
    //���ꂽ��false��
}
