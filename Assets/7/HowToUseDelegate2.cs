using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�ydelegate�p�r2�z�p�r1�ł́A�u�߂�lbool�^�A�����͔C�ӂ̌^�v��delegate���g���Ă����B
// �����ł́A�u�߂�l���C�ӂ̌^�v�ł��g����p�r���w�ԁB�֐����Ϗ�����p�r�ł���B
// �Q�[���X�^�[�g���ɂ�肽�������i�߂�l�Ȃ��A�����Ȃ��j�����������邪�A
// �����邩������Ȃ������邩������Ȃ��Ƃ����A���m��̃P�[�X���l���Ă݂�B
public class HowToUseDelegate2 : MonoBehaviour
{
    // Step1: �߂�l�Ȃ��A�����Ȃ���delegate StartDelegate���`
    public delegate void StartDelegate();

    // Step2: �߂�l�Ȃ��A�����Ȃ���InitPlayer�֐����`
    void InitPlayer() {
        /*
         * 
         * player�쐬����...
         * 
         */
        Debug.Log("Player�쐬���܂���");
    }

    // Step3: �߂�l�Ȃ��A�����Ȃ���InitEnemies�֐����`
    void InitEnemies() {
        /*
         * 
         * Enemy�쐬����...
         * 
         */
        Debug.Log("Enemy�쐬���܂���");
    }

    // Step4: �߂�l�Ȃ��A����StartDelegate�^startDelegate�́AInitialize�֐����`
    private void Initialize(StartDelegate startDelegate) {
        /*
         * 
         * �l�X�ȏ���������...
         * 
         */

        // Step5: startDelegate��Invoke�Ŏ��s
        startDelegate?.Invoke();
    }

    void Start() {
        // Step6: StartDelegate�^��startDelegate�ϐ����`
        StartDelegate startDelegate = null;

        // Step7: startDelegate�ɑ΂���InitPlayer����
        startDelegate = InitPlayer;

        // Step8: startDelegate�ɑ΂���InitEnemies��������(+=)
        startDelegate += InitEnemies;

        // Step9: Initialize�֐��ɁA�����܂łō����startDelegate��^���Ď��s���Ă��炤
        Initialize(startDelegate);//�K�v�ȏ������������܂Ƃ߂āA�Ϗ����Ă���
    }
}
