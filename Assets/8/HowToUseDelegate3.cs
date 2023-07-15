using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//【注意】ここでは、「イベント処理の登録／解除のみ行います」
// 一方、「delegateの定義、イベント処理の実行は行いません」
// それらは別のスクリプトJumpにて行います
// （1スクリプトにまとめるのは見やすくて楽ですが、登録／解除⇔実行
// は普通分けるので、ここでもそのように実装します）


// イベント処理の登録／解除
public class HowToUseDelegate3 : MonoBehaviour
{
    // Step5: delegateの定義やイベント処理を「実行」する役割をもっているJumpスクリプトを
    // ここで定義。変数名はjumpとしてシリアライズ化し、Jumpスクリプトがアタッチされている
    // Playerをインスペクタ上で指定しよう。
    

    void JumpEvent1() {
        Debug.Log("Event1");
    }
    void JumpEvent2() {
        Debug.Log("Event2");
    }
    void Start() {
        // Step6: jump変数がもつOnJumpedに対して、JumpEvent1とJumpEvent2を登録(+=)
        // ここまでで一旦実行し、スペースキーが押されるたびにEvent1, Event2が
        // Console上で表示されることを確認しましょう
        

        // Step7: OnJumpedからJumpEvent1を解除(-=)
        // これにより実行すると、Event2のみしか実行されないことを確認してください
        

        // Step8: 1,2,1を登録。表示はどうなると予想しますか？
        

        // Step9: 2を解除。表示はどうなると予想しますか？
        
    }
}
