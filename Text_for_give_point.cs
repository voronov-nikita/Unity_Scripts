using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //�������� UI 

public class MoneyText : MonoBehaviour
{
    public static int Coin;     //��� ����� ����
    private Text text;      //����� ��� ������


    void Start()
    {
        text = GetComponent<Text>();        //�������� ��������� ������
    }

    
    void Update()
    {
        text.text = Coin.ToString();        //������� �� ������ ��������
    }
}
