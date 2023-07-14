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
            Debug.Log("生きている");
        }
        else
        {
            Debug.Log("力尽きた！");
        }
    }
    void ShowNum(int num)
    {
        Debug.Log(num);
    }

    int _hp = 100;//playerのHP
    [SerializeField] Text _hpText;//HP表示テキスト
    void Update()
    {
        //CheckDeadのみ実行
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Check checker = null;
            checker = CheckDead;
            checker?.Invoke(_hp);
        }

        //ShowNumとCheckDeadを実行ののち、ShowNumのみ実行
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
    /// HPをUI表示する
    /// </summary>
    void ShowHP()
    {
        _hpText.text = "HP:" + _hp.ToString();
    }
}
