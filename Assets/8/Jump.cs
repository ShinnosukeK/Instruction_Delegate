using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�y���Ӂz�����ł́A�udelegate�̒�`�A�C�x���g�����̎��s�̂ݍs���܂��v
// ����A�u�C�x���g�����̓o�^�^�����͍s���܂���v
// �����͕ʂ̃X�N���v�gHowToUseDelegate3�ɂčs���܂�
// �i1�X�N���v�g�ɂ܂Ƃ߂�̂͌��₷���Ċy�ł����A�o�^�^�����̎��s
// �͕��ʕ�����̂ŁA�����ł����̂悤�Ɏ������܂��j

//delegate�̒�`�ƁA�C�x���g�����̎��s�{��
public class Jump : MonoBehaviour
{
    // Step1: �ydelegate�̒�`�z�߂�l�Ȃ��A�����Ȃ���delegate JumpHandler��錾
    // �����ŁAUnity�̃C�x���g�֘A�̕����ł�...Handler�Ƃ������O�ɂȂ�̂�����
    public delegate void JumpHandler();

    // Step2: Step1�Œ�`����JumpHandler�^�̕ϐ�OnJumped��錾
    // �����ŁA�u...�̃C�x���g�����������Ƃ��ɏ������邱�Ɓv
    //�i�����ł̓X�y�[�X�L�[�������̃C�x���g�ɂȂ�j
    // �I�ȈӖ��Ȃ̂ŁAOn...�Ƃ����ϐ����ɂȂ�̂�����
    public JumpHandler OnJumped;

    void Update() {
        // Step3: �X�y�[�X�L�[�������ꂽ��
        if(Input.GetKeyDown(KeyCode.Space)) {
            // Step4: OnJumped��Invoke����
            OnJumped?.Invoke();
        }
    }
}