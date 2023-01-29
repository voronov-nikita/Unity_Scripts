using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)     //при входе в тригер
    {
        if (collision.CompareTag("Player"))     //проверяем на присутствие тега 
        {
            MoneyText.Coin += 1;                //прибавляем 
            Destroy(gameObject);            //удаляем эллемент
        }
    }
}