using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�ydelegate�p�r1�zif���̏������������ւ���ړI�Ŏg�p
public class HowToUseDelegate1 : MonoBehaviour
{
    // Step1: �߂�lbool�^�A����int�^num��delegate Checker���`
    

    // Step2: �߂�l�Ȃ��A�������@delegate Checker�^�A�Aint�^num������Check�֐����`
    void Check(�����ɒǋL) {
        // Step3: if����������ɁAInvoke��num��^���ė��p����
        // �ʉ߂�����u����(num�jOK�v�_���Ȃ�u����(num)NG�v�Əo��
        
    }

    void Start() {
        int hp = 5000;

        // Step4: Checker�^checker���`���ACanDefeatZako����
        

        // Step5: Check�֐��ɁAchecker��hp��^���ČĂ�
        

        // Step6: checker��CanDefeatBoss���đ��
        

        // Step7: Check�֐��ɁAchecker��hp��^���ČĂ�
        
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
