using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�y���Ӂz�����ł́A�u�C�x���g�����̓o�^�^�����̂ݍs���܂��v
// ����A�udelegate�̒�`�A�C�x���g�����̎��s�͍s���܂���v
// �����͕ʂ̃X�N���v�gJump�ɂčs���܂�
// �i1�X�N���v�g�ɂ܂Ƃ߂�̂͌��₷���Ċy�ł����A�o�^�^�����̎��s
// �͕��ʕ�����̂ŁA�����ł����̂悤�Ɏ������܂��j


// �C�x���g�����̓o�^�^����
public class HowToUseDelegate3 : MonoBehaviour
{
    // Step5: delegate�̒�`��C�x���g�������u���s�v��������������Ă���Jump�X�N���v�g��
    // �����Œ�`�B�ϐ�����jump�Ƃ��ăV���A���C�Y�����AJump�X�N���v�g���A�^�b�`����Ă���
    // Player���C���X�y�N�^��Ŏw�肵�悤�B
    

    void JumpEvent1() {
        Debug.Log("Event1");
    }
    void JumpEvent2() {
        Debug.Log("Event2");
    }
    void Start() {
        // Step6: jump�ϐ�������OnJumped�ɑ΂��āAJumpEvent1��JumpEvent2��o�^(+=)
        // �����܂łň�U���s���A�X�y�[�X�L�[��������邽�т�Event1, Event2��
        // Console��ŕ\������邱�Ƃ��m�F���܂��傤
        

        // Step7: OnJumped����JumpEvent1������(-=)
        // ����ɂ����s����ƁAEvent2�݂̂������s����Ȃ����Ƃ��m�F���Ă�������
        

        // Step8: 1,2,1��o�^�B�\���͂ǂ��Ȃ�Ɨ\�z���܂����H
        

        // Step9: 2�������B�\���͂ǂ��Ȃ�Ɨ\�z���܂����H
        
    }
}
