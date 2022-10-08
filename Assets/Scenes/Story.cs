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
                //ルートAに
            }
        }
        else if(b == true)
        {
            rootB++;
            b = false;
            if (rootB == 5)
            {
                //ルートBに
            }
        }
        else if(c == true)
        {
            rootC++;
            c = false;
            if (rootC == 5)
            {
                //ルートCに
            }
        }
        else
        {

        }
    }
    /*
    謎が謎を呼ぶ　後からだんだんわかってくる
    認識阻害系　こういうストーリーだと思ったら実は視点を変えたらまったく違う話だった　敵だと思っていたやつが自分を守ろうとしていた
    防衛機制が敵とかギミックだったり　自分を守るための
    考察の余地　精神系の病院はスマホとか取り上げられる
    現代でスマホなかったら、察せる　スマホがないことで情報を得手段が探索に絞られる
    あえて探索をに出てくる紙に誤った情報を紛れ込ませることでミスリードに　
    何故病院から出るのか　モンスターとか敵とか出しといて、出なきゃと思わせる、此処から出ろという(ミスリードに)　意図的な　実は己自身？
    */
}
