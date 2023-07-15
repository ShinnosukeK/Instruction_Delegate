using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//delegate�̒�`�ƁA�C�x���g�����̎��s�{��
public class Jump : MonoBehaviour
{
    public delegate void JumpHandler();

    // Step2: event�L�[���[�h��ǉ�
    // ����ɂ��A�O�������������s���ł��Ȃ��Ȃ��Ă���A
    // ���Ƃ̃X�N���v�g���ŃG���[�ƂȂ��Ă��邱�Ƃ��m�F���悤
    public event JumpHandler OnJumped;

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            OnJumped?.Invoke();
        }
    }
}