using UnityEngine;

public class Story : MonoBehaviour
{
    bool a = false;
    bool b = false;
    bool c = false;
    int rootA = 0;
    int rootB = 0;
    int rootC = 0;

    void Update()
    {
        if(a == true)
        {
            rootA++;
            a = false;
            if(rootA == 5)
            {
                //���[�gA��
            }
        }
        else if(b == true)
        {
            rootB++;
            b = false;
            if (rootB == 5)
            {
                //���[�gB��
            }
        }
        else if(c == true)
        {
            rootC++;
            c = false;
            if (rootC == 5)
            {
                //���[�gC��
            }
        }
        else
        {

        }
    }
    /*
    �䂪����Ăԁ@�ォ�炾�񂾂�킩���Ă���
    �F���j�Q�n�@���������X�g�[���[���Ǝv��������͎��_��ς�����܂������Ⴄ�b�������@�G���Ǝv���Ă��������������낤�Ƃ��Ă���
    �h�q�@�����G�Ƃ��M�~�b�N��������@��������邽�߂�
    �l�@�̗]�n�@���_�n�̕a�@�̓X�}�z�Ƃ����グ����
    ����ŃX�}�z�Ȃ�������A�@����@�X�}�z���Ȃ����Ƃŏ��𓾎�i���T���ɍi����
    �����ĒT�����ɏo�Ă��鎆�Ɍ�������𕴂ꍞ�܂��邱�ƂŃ~�X���[�h�Ɂ@
    ���̕a�@����o��̂��@�����X�^�[�Ƃ��G�Ƃ��o���Ƃ��āA�o�Ȃ���Ǝv�킹��A��������o��Ƃ���(�~�X���[�h��)�@�Ӑ}�I�ȁ@���͌Ȏ��g�H
    */
}
