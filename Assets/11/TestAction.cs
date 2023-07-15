using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Step1: Action使用のために、名前空間using Systemをする必要がある
using System;

public class TestAction : MonoBehaviour
{
    /*
     * 
     * さて、
     * Predicate → 【戻り値bool】　【引数 任意の型 1個】
     * でしたが、Actionという定義済みdelegateは、
     * Action    → 【戻り値なし】　【引数なし　or 引数任意の型1～16個】
     * で使うことができます。Predicateとは違い引数がないときはAction action;のように宣言でき、
     * 引数int, stringを取る場合はAction<int, string> action;というように宣言できます。
     * あとは同じです。
     * 
     */

    // Step2:【チャレンジ】int hp, string nameを受け取って、「(name)のHPは(hp)です」と表示する
    // だけの関数Show(int hp, string name)を作ってください。そして、
    // int, stringを受け取るAction型 action変数を作って、actionにShowを委譲することで
    // 実行してみてください。自由に組んでみましょう。

    void Show(int hp, string name) {
        Debug.Log($"{name}のHPは{hp}です");//いちいちstring同士の足し算面倒なのでこれも書けるように
    }

    void Start() {
        int hp = 20000;
        string name = "Kitayama";
        Action<int,string> action = null;
        action += Show;
    }

}
