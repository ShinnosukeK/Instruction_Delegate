using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Step1: Action�g�p�̂��߂ɁA���O���using System������K�v������
using System;

public class TestAction : MonoBehaviour
{
    /*
     * 
     * ���āA
     * Predicate �� �y�߂�lbool�z�@�y���� �C�ӂ̌^ 1�z
     * �ł������AAction�Ƃ�����`�ς�delegate�́A
     * Action    �� �y�߂�l�Ȃ��z�@�y�����Ȃ��@or �����C�ӂ̌^1�`16�z
     * �Ŏg�����Ƃ��ł��܂��BPredicate�Ƃ͈Ⴂ�������Ȃ��Ƃ���Action action;�̂悤�ɐ錾�ł��A
     * ����int, string�����ꍇ��Action<int, string> action;�Ƃ����悤�ɐ錾�ł��܂��B
     * ���Ƃ͓����ł��B
     * 
     */

    // Step2:�y�`�������W�zint hp, string name���󂯎���āA�u(name)��HP��(hp)�ł��v�ƕ\������
    // �����̊֐�Show(int hp, string name)������Ă��������B�����āA
    // int, string���󂯎��Action�^ action�ϐ�������āAaction��Show���Ϗ����邱�Ƃ�
    // ���s���Ă݂Ă��������B���R�ɑg��ł݂܂��傤�B

    void Show(int hp, string name) {
        Debug.Log($"{name}��HP��{hp}�ł�");//��������string���m�̑����Z�ʓ|�Ȃ̂ł����������悤��
    }

    void Start() {
        int hp = 20000;
        string name = "Kitayama";
        Action<int,string> action = null;
        action += Show;
    }

}
