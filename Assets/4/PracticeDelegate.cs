using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�y�e�[�}�z������delegate���������K

public class PracticeDelegate : MonoBehaviour
{
    // Step1: �߂�l�Ȃ��A������int�^ num��string�^ str��delegate ShowInfo���`
    public delegate void ShowInfo(int num, string str);

    // Step2: �߂�l�Ȃ��A������int�^ age��string�^ name�̊֐�ShowPerson���`���A
    // �u���O��(name�j�ŁA�N���(age)�ł��v�ƕ\������悤�ɂ��Ă�������
    void ShowPerson(int age, string name)
    {
        Debug.Log("���O��" + name + "�ŁA�N���" + age + "�ł�");
    }

    void Start()
    {
        // Step3: ShowInfo�^��showInfo�ϐ���錾��null���
        ShowInfo showInfo = null;

        // Step4: showInfo��ShowPerson�֐�����
        showInfo = ShowPerson;

        // Step5: ��null�`�F�b�N����Invoke��showInfo�����s
        // ���̍ہA�����ɂ�29��"�k�R"�����邱��
        // �����܂ŏI�������A�K���ȃI�u�W�F�N�g�ɃA�^�b�`���Ď��s���邱��
        showInfo?.Invoke(29, "�k�R");
    }
}
