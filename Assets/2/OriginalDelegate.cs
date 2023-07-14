using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//【テーマ】delegateがnullだった場合の安全処理を追加しよう

public class OriginalDelegate : MonoBehaviour
{
    public delegate void Check(int num);

    void CheckDead(int hp)
    {
        if (hp > 0)
        {
            Debug.Log("生きている");
        }
        else
        {
            Debug.Log("力尽きた！");
        }
    }

    int _hp = 100;//playerのHP
    [SerializeField] Text _hpText;//HP表示テキスト
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Check checker = null;

            // Step1: CheckDeadを代入している以下の文をコメントアウトするとエラーが出ることを確認してください
            checker = CheckDead;

            // Step2: Step1のコメントアウトを解除し、
            // 以下の文全体をif文で包み、「もしもcheckerがnullではないなら」実行するようにしてください
            /*
            if(checker != null)
            {
                checker(_hp);
            }
            */

            // Step3: 上に書いたif文は長ったらしいです。それを、null条件演算子?を用いて、
            // checker?.Invoke(_hp)で楽にかけることを確認してください。
            checker?.Invoke(_hp);

            // Step4: そして、Step3の手順は、checker?(_hp)とはかけないことを確認してください。
            // したがって、checker(_hp)という使い方を紹介したものの、
            // 推奨されるのはInvokeを使った、checker?.Invoke(_hp)です。よって、基本Invoke使いましょう。
            // checker?(_hp); ←これはできない！
        }

        ShowHP();
    }

    /// <summary>
    /// HPをUI表示する
    /// </summary>
    void ShowHP()
    {
        _hpText.text = "HP:" + _hp.ToString();
    }
}
