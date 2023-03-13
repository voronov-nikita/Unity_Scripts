using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //вызываем UI 

public class MoneyText : MonoBehaviour
{
    public static int Coin;     //что такое коин
    private Text text;      //текст для текста


    void Start()
    {
        text = GetComponent<Text>();        //получаем компонент текста
    }

    
    void Update()
    {
        text.text = Coin.ToString();        //отсылка на другой эллемент
    }
}
