using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Step1: Predicate�g�p�̂��߂ɁA���O���using System������K�v������


public class TestPredicate : MonoBehaviour
{
    // ���܂ŁA�����ł��ׂ�delegate���`���Ă��܂����B
    // public delegate bool Hoge(int num)���������Ƃ��āA���ꂾ���Ȃ炢�����̂́A
    // �������߂�l��bool������string str���󂯎��Ȃ�A
    // public delegate bool Hoge2(string str)���`���Ȃ��Ƃ����Ȃ��̂��H
    // �ƂȂ��Ă��܂��B���́AC#��Unity�ɂ͂悭�g��delegate�����łɒ�`����Ă��܂��B
    // �����ł͂܂��A
    // �y�߂�l bool�^�z�y���� �C�ӂ̌^ 1�z
    // �Ƃ邱�Ƃ̂ł���Predicate�Ƃ���delegate���g���Ă݂܂��傤�B

    // Step2: ����delegate�̒�`��Predicate���s���Ă���̂ŁA������g���Đ錾���邾���ł��B
    // �����APredicate�̈����̌^�͎��R�Ȃ̂ŁA
    // Predicate<int>�Ƃ����悤�ɂ��ċ����Ă�����K�v������܂��B�ϐ�����predicate�Ƃ��܂��B
    

    // Step3: �߂�l�Ȃ��A�����@Predicate<int>�^��predicate�A�����Aint num
    �����ɏ���() {
        // Step4: predicate��Invoke����B������num��^����B
        if() {
            Debug.Log("����OK");
        } else {
            Debug.Log("����NG");
        }
    }

    void Start() {
        int hp = 20000;

        // Step5: predicate��CanDefeatZako��CanDefeatBoss��ǉ�
        

        // Step6: Check�֐���predicate��hp��n���Ď��s
        
    }

    //�O�̖��ō�����Aint�������Ƃ���bool��Ԃ��֐�
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
