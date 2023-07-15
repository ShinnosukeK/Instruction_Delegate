using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// イベント処理の登録／解除
public class HowToUseDelegate3 : MonoBehaviour
{
    [SerializeField] Jump jump;

    void JumpEvent1() {
        Debug.Log("Event1");
    }
    void JumpEvent2() {
        Debug.Log("Event2");
    }
    void Start() {
        jump.OnJumped += JumpEvent1;
        jump.OnJumped += JumpEvent2;

        // Step1:【問題点】イベント処理の登録／解除のみをこちらでは行うが...
        // ①以下のようにOnJumpedに対してJumpEvent1を「代入」できてしまうと、
        // 今までの登録がすべて抹消され、JumpEvent1のみになってしまう。
        // これが外部から許されてしまったら、まずい...
        // ②さらに、jump.OnJumped?.Invoke()がこちらでも実行できてしまうので、
        // Jumpスクリプト側に実行処理を分ける意味がないじゃん、という話になってしまう。
        // まずはこのまま実行してみて、確かにJumpEvent1のみになってしまっているし、
        // 実行も行えてしまっていることを確認しましょう。
        jump.OnJumped = JumpEvent1;
        jump.OnJumped?.Invoke();
    }
}