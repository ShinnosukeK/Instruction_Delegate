using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//delegateの定義と、イベント処理の実行本体
public class Jump : MonoBehaviour
{
    public delegate void JumpHandler();

    // Step2: eventキーワードを追加
    // これにより、外部から代入も実行もできなくなっており、
    // もとのスクリプト側でエラーとなっていることを確認しよう
    public event JumpHandler OnJumped;

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            OnJumped?.Invoke();
        }
    }
}