using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//【delegate用途1】if文の条件式を差し替える目的で使用
public class HowToUseDelegate1 : MonoBehaviour
{
    // Step1: 戻り値bool型、引数int型numのdelegate Checkerを定義
    public delegate bool Checker(int num);

    // Step2: 戻り値なし、引数を�@delegate Checker型、�Aint型numを取れるCheck関数を定義
    void Check(Checker checker, int num) {
        // Step3: if文条件判定に、Invokeにnumを与えて利用する
        // 通過したら「引数(num）OK」ダメなら「引数(num)NG」と出力
        if((bool)checker?.Invoke(num)) {
            Debug.Log("引数" + num + "OK");
        } else {
            Debug.Log("引数" + num + "NG");
        }
    }

    void Start() {
        int hp = 5000;

        // Step4: Checker型checkerを定義し、CanDefeatZakoを代入
        Checker checker = CanDefeatZako;

        // Step5: Check関数に、checkerとhpを与えて呼ぶ
        Check(checker, hp);

        // Step6: checkerにCanDefeatBossを再代入
        checker = CanDefeatBoss;

        // Step7: Check関数に、checkerとhpを与えて呼ぶ
        Check(checker, hp);
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
