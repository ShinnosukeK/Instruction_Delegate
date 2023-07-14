using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OriginalDelegate : MonoBehaviour
{
    // Step1: �֐����Ăяo���Ƃ��ɁA�y�߂�l�̌^�z�Ɓy�����̌^�z�͌��肵�Ă��邪�A
    // ��̓I�ȏ����͌��܂��Ă��Ȃ����߃{�J�������Ƃ��Adelegate���g����B
    // ����́A�y�߂�l�Ȃ��z�A�y����int�z�Ƃ��āAdelegate���`���Ă݂悤�B
    // ���@�́A
    // �y�A�N�Z�X�C���q�@�z delegate �y�߂�l�̌^�A�z�y�C�ӂ̃��\�b�h���B�i�����̌^�w��C�j�z�ƂȂ�B
    // �����ł͇@=public�A�A=void�A�B=Check�i�C�Ӂj�A�C=int num�Ƃ��Ă݂悤�B
    public delegate void Check(int num);

    // Step2: CheckDead�Ƃ����A�߂�l�Ȃ��A����int hp�̊֐����`���Aplayer��hp��1�ȏ�Ȃ�u�����Ă���v
    // �����łȂ��Ȃ�u�͐s�����I�v�Ƃ����\�����s���悤�ɂ��Ă��������B
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
        // Step3: Space�L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Step4: Check�^�i���߂�l�Ȃ��A����int���m�肵�Ă���delegate�^�j��
            // �ϐ�checker��錾
            Check checker;
            // Step5: checker�ɑ΂���CheckDead�֐���������B���̍�CheckDead(...)��()�͕s�v
            checker = CheckDead;

            // Step6: checker�ɑ΂��Ĉ���_hp��^���Ď��s����i�ŏ���HP��100�Ȃ̂ŁA�u�����Ă���v���\�������j
            checker(_hp);

            // Step7: Step6���R�����g�A�E�g���Achecker��Invoke�֐��ɑ΂��Ĉ���_hp��^���ē������ʂɂȂ邱�Ƃ��m�F���悤
            checker.Invoke(_hp);
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
