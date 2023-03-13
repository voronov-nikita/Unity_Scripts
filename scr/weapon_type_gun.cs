using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject patron;       //обьект префаб патрон которым мы будем стрелять
    public Transform shotpoint;     //получем позицию обьекта откуда мы будем стрелять 

    private float timeSetgun;       //время 
    public  float startTimeSet;         //перезарядка

    
    void Start()
    {
        
    }

    
    void Update()
    {   if(timeSetgun <= 0)         //условие если перезарядка не закочилась
        {
            if (Input.GetKeyDown(KeyCode.R))            //если нажали на кнопку...
            {
                Instantiate(patron, shotpoint.position, transform.rotation);        //получаем патрон, позицию откуда мы стреляем, положение в какую сторону стрелять
                timeSetgun = startTimeSet;      //приравниваем значения перезарядки и времени перезарядки
            }
        }
        else
        {
            timeSetgun -= Time.deltaTime;       //вычитаем перезарядку от времени перезарядки
        }
        
    }
}
