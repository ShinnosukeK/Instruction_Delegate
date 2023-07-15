using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//【delegate用途2】用途1では、「戻り値bool型、引数は任意の型」のdelegateを使っていた。
// ここでは、「戻り値も任意の型」でも使える用途を学ぶ。関数を委譲する用途である。
// ゲームスタート時にやりたい処理（戻り値なし、引数なし）がいくつかあるが、
// 増えるかもしれないし減るかもしれないという、未確定のケースを考えてみる。
public class HowToUseDelegate2 : MonoBehaviour
{
    // Step1: 戻り値なし、引数なしのdelegate StartDelegateを定義
    

    // Step2: 戻り値なし、引数なしのInitPlayer関数を定義
    ここに書いてください() {
        /*
         * 
         * player作成処理...
         * 
         */
        Debug.Log("Player作成しました");
    }

    // Step3: 戻り値なし、引数なしのInitEnemies関数を定義
    ここに書いてください() {
        /*
         * 
         * Enemy作成処理...
         * 
         */
        Debug.Log("Enemy作成しました");
    }

    // Step4: 戻り値なし、引数StartDelegate型startDelegateの、Initialize関数を定義
    ここに書いてください() {
        /*
         * 
         * 様々な初期化処理...
         * 
         */

        // Step5: startDelegateをInvokeで実行
        
    }

    void Start() {
        // Step6: StartDelegate型のstartDelegate変数を定義
        

        // Step7: startDelegateに対してInitPlayerを代入
        

        // Step8: startDelegateに対してInitEnemiesを加える(+=)
        

        // Step9: Initialize関数に、ここまでで作ったstartDelegateを与えて実行してもらう
        
    }
}
