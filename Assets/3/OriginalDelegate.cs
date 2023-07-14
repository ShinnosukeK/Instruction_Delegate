using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//【テーマ】delegateには+=が使えて、関数の実行が複数できることを見よう

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
    // Step1: 渡されたint型の値を表示するだけの、【戻り値なし】【引数int num】
    // の関数ShowNumを定義してください。


    int _hp = 100;//playerのHP
    [SerializeField] Text _hpText;//HP表示テキスト
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Check checker = null;
            checker = CheckDead;
            checker?.Invoke(_hp);
        }

        // Step2: Dキーが押されたら
        if ()
        {
            // Step3: Check型 checkerを宣言しnull代入


            // Step4: checkerにShowNumを代入


            // Step5: checkerにCheckDeadを足す（+=を使う）


            // Step6: 非nullチェックをしつつInvokeでcheckerに_hpを渡して実行（どうなってる？）


            // Step7: checkerに改めてShowNumを代入（するとStep8の結果はどうなる？）


            // Step8: Step6のコピー

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
