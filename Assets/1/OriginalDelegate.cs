using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OriginalDelegate : MonoBehaviour
{
    // Step1: 関数を呼び出すときに、【戻り値の型】と【引数の型】は決定しているが、
    // 具体的な処理は決まっていないためボカしたいとき、delegateが使える。
    // 今回は、【戻り値なし】、【引数int】として、delegateを定義してみよう。
    // 文法は、
    // 【アクセス修飾子①】 delegate 【戻り値の型②】【任意のメソッド名③（引数の型指定④）】となる。
    // ここでは①=public、②=void、③=Check（任意）、④=int numとしてみよう。


    // Step2: CheckDeadという、戻り値なし、引数int hpの関数を定義し、playerのhpが1以上なら「生きている」
    // そうでないなら「力尽きた！」という表示を行うようにしてください。


    int _hp = 100;//playerのHP
    [SerializeField] Text _hpText;//HP表示テキスト
    void Update()
    {
        // Step3: Spaceキーが押されたら
        if ()
        {
            // Step4: Check型（＝戻り値なし、引数intが確定しているdelegate型）の
            // 変数checkerを宣言

            // Step5: checkerに対してCheckDead関数を代入する。その際CheckDead(...)の()は不要


            // Step6: checkerに対して引数_hpを与えて実行する（最初のHPは100なので、「生きている」が表示される）


            // Step7: Step6をコメントアウトし、checkerのInvoke関数に対して引数_hpを与えて同じ結果になることを確認しよう

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
