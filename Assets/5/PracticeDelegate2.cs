using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//�y�e�[�}�z������delegate���������K2

public class PracticeDelegate2 : MonoBehaviour
{
    // Step1: �߂�lbool�A������int�^ num��delegate Check���`
    public delegate bool Check(int num);

    // Step2: �߂�lbool�A������int�^ hp�̊֐�CanDefeatBoss���`���A
    // �󂯎����hp��10000�ȏ�Ȃ�true�i���{�X�ɏ��Ă�j���A
    // �����łȂ��Ȃ�false�i���{�X�ɕ�����j��Ԃ��Ă��������B
    bool CanDefeatBoss(int hp)
    {
        if (hp >= 10000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Step3: �߂�lbool�A������int�^ hp�̊֐�CanDefeatZako���`���A
    // �󂯎����hp��100�ȏ�Ȃ�true�i���G���ɏ��Ă�j���A
    // �����łȂ��Ȃ�false�i���G���ɕ�����j��Ԃ��Ă��������B
    bool CanDefeatZako(int hp)
    {
        if (hp >= 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Start()
    {
        // Step4: Check�^��checker�ϐ���錾��null���
        Check checker = null;

        // Step5: checker��CanDefeatZako�֐�����
        checker = CanDefeatZako;

        // Step6: checker��CanDefeatBoss�֐��𑫂�(+=)
        checker += CanDefeatBoss;


        // Step7: ��null�`�F�b�N����Invoke��checker�����s����B
        // �߂�l��bool������A�ȉ���if���̔���ɓ��ꍞ��ł݂悤�B
        // ���̂Ƃ��Abool?�^����bool�^�ւ̋����^�ϊ������邽�߁A
        // (bool)checker.....Invoke(??)�Ƃ����悤�ȏ����������邱��
        // ���Ƃ́A�K���ɏ���HP��SerializeField�ɂ����inpector��
        // �ł������Ă݂āA�������`�F�b�N���Ă݂邱��
        if ((bool)checker?.Invoke(_hp))
        {
            Debug.Log("if���ʂ���");
        }
        else
        {
            Debug.Log("if���ʂ��ĂȂ�");
        }
    }


    [SerializeField] int _hp;//player��HP
    [SerializeField] Text _hpText;//HP�\���e�L�X�g
    void Update()
    {
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
