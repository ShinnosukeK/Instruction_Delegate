using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//【テーマ】自分でdelegateを書く練習2

public class PracticeDelegate2 : MonoBehaviour
{
    // Step1: 戻り値bool、引数がint型 numのdelegate Checkを定義

    // Step2: 戻り値bool、引数がint型 hpの関数CanDefeatBossを定義し、
    // 受け取ったhpが10000以上ならtrue（＝ボスに勝てる）を、
    // そうでないならfalse（＝ボスに負ける）を返してください。


    // Step3: 戻り値bool、引数がint型 hpの関数CanDefeatZakoを定義し、
    // 受け取ったhpが100以上ならtrue（＝雑魚に勝てる）を、
    // そうでないならfalse（＝雑魚に負ける）を返してください。


    void Start()
    {
        // Step4: Check型のchecker変数を宣言しnull代入


        // Step5: checkerにCanDefeatZako関数を代入


        // Step6: checkerにCanDefeatBoss関数を足す(+=)



        // Step7: 非nullチェックしつつInvokeでcheckerを実行する。
        // 戻り値がboolだから、以下のif文の判定に入れ込んでみよう。
        // このとき、bool?型からbool型への強制型変換をするため、
        // (bool)checker.....Invoke(??)というような書き方をすること
        // あとは、適当に初期HPをSerializeFieldによってinpector側
        // でいじってみて、挙動をチェックしてみること
        if ()
        {
            Debug.Log("if文通った");
        }
        else
        {
            Debug.Log("if文通ってない");
        }
    }


    [SerializeField] int _hp;//playerのHP
    [SerializeField] Text _hpText;//HP表示テキスト
    void Update()
    {
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
