using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPredicate : MonoBehaviour
{
    // 今まで、自分ですべてdelegateを定義してきました。
    // public delegate bool Hoge(int num)があったとして、これだけならいいものの、
    // 同じく戻り値がboolだけどstring strを受け取るなら、
    // public delegate bool Hoge2(string str)を定義しないといけないのか？
    // となってきます。実は、C#とUnityにはよく使うdelegateがすでに定義されています。
    // ここではまず、
    // 【戻り値 bool型】【引数 任意の型1から16個】
    // とることのできるPredicateというdelegateを使ってみましょう。

}
