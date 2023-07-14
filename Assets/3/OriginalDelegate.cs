using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    void ShowNum(int num)
    {
        Debug.Log(num);
    }

    int _hp = 100;//player��HP
    [SerializeField] Text _hpText;//HP�\���e�L�X�g
    void Update()
    {
        //CheckDead�̂ݎ��s
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Check checker = null;
            checker = CheckDead;
            checker?.Invoke(_hp);
        }

        //ShowNum��CheckDead�����s�̂̂��AShowNum�̂ݎ��s
        if (Input.GetKeyDown(KeyCode.D))
        {
            Check checker = null;

            checker = ShowNum;
            checker += CheckDead;
            checker?.Invoke(_hp);

            checker = ShowNum;
            checker?.Invoke(_hp);
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
