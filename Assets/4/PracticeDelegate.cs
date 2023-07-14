using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//【テーマ】delegateを書く練習

public class PracticeDelegate : MonoBehaviour
{
    // Step1: 戻り値なし、引数がint型 numとstring型 strのdelegate ShowInfoを定義


    // Step2: 戻り値なし、引数がint型 ageとstring型 nameの関数ShowPersonを定義し、
    // 「名前は(name）で、年齢は(age)です」と表示するようにしてください


    void Start()
    {
        // Step3: ShowInfo型のshowInfo変数を宣言しnull代入


        // Step4: showInfoにShowPerson関数を代入


        // Step5: 非nullチェックしつつInvokeでshowInfoを実行
        // その際、引数には29と"北山"を入れること
        // ここまで終わったら、適当なオブジェクトにアタッチして実行すること

    }
}
