using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Step1: Predicate使用のために、名前空間using Systemをする必要がある


public class TestPredicate : MonoBehaviour
{
    // 今まで、自分ですべてdelegateを定義してきました。
    // public delegate bool Hoge(int num)があったとして、これだけならいいものの、
    // 同じく戻り値がboolだけどstring strを受け取るなら、
    // public delegate bool Hoge2(string str)を定義しないといけないのか？
    // となってきます。実は、C#とUnityにはよく使うdelegateがすでに定義されています。
    // ここではまず、
    // 【戻り値 bool型】【引数 任意の型 1個】
    // とることのできるPredicateというdelegateを使ってみましょう。

    // Step2: もうdelegateの定義はPredicateが行っているので、それを使って宣言するだけです。
    // ただ、Predicateの引数の型は自由なので、
    // Predicate<int>というようにして教えてあげる必要があります。変数名はpredicateとします。
    

    // Step3: 戻り値なし、引数①Predicate<int>型のpredicate、引数②int num
    ここに書く() {
        // Step4: predicateをInvokeする。引数にnumを与える。
        if() {
            Debug.Log("条件OK");
        } else {
            Debug.Log("条件NG");
        }
    }

    void Start() {
        int hp = 20000;

        // Step5: predicateにCanDefeatZakoとCanDefeatBossを追加
        

        // Step6: Check関数にpredicateとhpを渡して実行
        
    }

    //前の問題で作った、intを引数としてboolを返す関数
    bool CanDefeatBoss(int hp) {
        if(hp >= 10000) {
            return true;
        } else {
            return false;
        }
    }
    bool CanDefeatZako(int hp) {
        if(hp >= 100) {
            return true;
        } else {
            return false;
        }
    }
}
