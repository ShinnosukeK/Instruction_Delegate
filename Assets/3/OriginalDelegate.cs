using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//�y�e�[�}�zdelegate�ɂ�+=���g���āA�֐��̎��s�������ł��邱�Ƃ����悤

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
    // Step1: �n���ꂽint�^�̒l��\�����邾���́A�y�߂�l�Ȃ��z�y����int num�z
    // �̊֐�ShowNum���`���Ă��������B


    int _hp = 100;//player��HP
    [SerializeField] Text _hpText;//HP�\���e�L�X�g
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Check checker = null;
            checker = CheckDead;
            checker?.Invoke(_hp);
        }

        // Step2: D�L�[�������ꂽ��
        if ()
        {
            // Step3: Check�^ checker��錾��null���


            // Step4: checker��ShowNum����


            // Step5: checker��CheckDead�𑫂��i+=���g���j


            // Step6: ��null�`�F�b�N������Invoke��checker��_hp��n���Ď��s�i�ǂ��Ȃ��Ă�H�j


            // Step7: checker�ɉ��߂�ShowNum�����i�����Step8�̌��ʂ͂ǂ��Ȃ�H�j


            // Step8: Step6�̃R�s�[

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
