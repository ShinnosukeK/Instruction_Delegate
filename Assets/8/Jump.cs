using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//【注意】ここでは、「delegateの定義、イベント処理の実行のみ行います」
// 一方、「イベント処理の登録／解除は行いません」
// それらは別のスクリプトHowToUseDelegate3にて行います
// （1スクリプトにまとめるのは見やすくて楽ですが、登録／解除⇔実行
// は普通分けるので、ここでもそのように実装します）

//delegateの定義と、イベント処理の実行本体
public class Jump : MonoBehaviour
{
    // Step1: 【delegateの定義】戻り値なし、引数なしのdelegate JumpHandlerを宣言
    // ここで、Unityのイベント関連の文脈では...Handlerという名前になるのが普通
    public delegate void JumpHandler();

    // Step2: Step1で定義したJumpHandler型の変数OnJumpedを宣言
    // ここで、「...のイベントが発生したときに処理すること」
    //（ここではスペースキー押下時のイベントになる）
    // 的な意味なので、On...という変数名になるのが普通
    public JumpHandler OnJumped;

    void Update() {
        // Step3: スペースキーが押されたら
        if(Input.GetKeyDown(KeyCode.Space)) {
            // Step4: OnJumpedをInvokeする
            OnJumped?.Invoke();
        }
    }
}