using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �C�x���g�����̓o�^�^����
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

        // Step1:�y���_�z�C�x���g�����̓o�^�^�����݂̂�������ł͍s����...
        // �@�ȉ��̂悤��OnJumped�ɑ΂���JumpEvent1���u����v�ł��Ă��܂��ƁA
        // ���܂ł̓o�^�����ׂĖ�������AJumpEvent1�݂̂ɂȂ��Ă��܂��B
        // ���ꂪ�O�����狖����Ă��܂�����A�܂���...
        // �A����ɁAjump.OnJumped?.Invoke()��������ł����s�ł��Ă��܂��̂ŁA
        // Jump�X�N���v�g���Ɏ��s�����𕪂���Ӗ����Ȃ������A�Ƃ����b�ɂȂ��Ă��܂��B
        // �܂��͂��̂܂܎��s���Ă݂āA�m����JumpEvent1�݂̂ɂȂ��Ă��܂��Ă��邵�A
        // ���s���s���Ă��܂��Ă��邱�Ƃ��m�F���܂��傤�B
        jump.OnJumped = JumpEvent1;
        jump.OnJumped?.Invoke();
    }
}