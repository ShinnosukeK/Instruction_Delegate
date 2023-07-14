using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//�y�e�[�}�zdelegate��null�������ꍇ�̈��S������ǉ����悤

public class OriginalDelegate : MonoBehaviour
{
    public delegate void Check(int num);

    void CheckDead(int hp)
    {
        if (hp > 0)
        {
            Debug.Log("�����Ă���");
        }
        else
        {
            Debug.Log("�͐s�����I");
        }
    }

    int _hp = 100;//player��HP
    [SerializeField] Text _hpText;//HP�\���e�L�X�g
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Check checker = null;

            // Step1: CheckDead�������Ă���ȉ��̕����R�����g�A�E�g����ƃG���[���o�邱�Ƃ��m�F���Ă�������
            checker = CheckDead;

            // Step2: Step1�̃R�����g�A�E�g���������A
            // �ȉ��̕��S�̂�if���ŕ�݁A�u������checker��null�ł͂Ȃ��Ȃ�v���s����悤�ɂ��Ă�������
            /*
            if(checker != null)
            {
                checker(_hp);
            }
            */

            // Step3: ��ɏ�����if���͒������炵���ł��B������Anull�������Z�q?��p���āA
            // checker?.Invoke(_hp)�Ŋy�ɂ����邱�Ƃ��m�F���Ă��������B
            checker?.Invoke(_hp);

            // Step4: �����āAStep3�̎菇�́Achecker?(_hp)�Ƃ͂����Ȃ����Ƃ��m�F���Ă��������B
            // ���������āAchecker(_hp)�Ƃ����g�������Љ�����̂́A
            // ���������̂�Invoke���g�����Achecker?.Invoke(_hp)�ł��B����āA��{Invoke�g���܂��傤�B
            // checker?(_hp); ������͂ł��Ȃ��I
        }

        ShowHP();
    }

    /// <summary>
    /// HP��UI�\������
    /// </summary>
    void ShowHP()
    {
        _hpText.text = "HP:" + _hp.ToString();
    }
}
