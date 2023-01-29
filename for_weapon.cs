using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;     //скорость
    public float lifetime;      //жизнь пули
    public float distance;      //дистанция об ударе
    public int damage;          //урон пули
    public LayerMask whatIs;        //что считать твердым



    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIs);   //задаем что такое твердое
        if (hitInfo.collider != null)       //считываем колайдер
        {
            if(hitInfo.collider.CompareTag("Enemy"))        //колайдер по тегу Enemy
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);  //получаем компонент Enemy и его урон
            }
            Destroy(gameObject);        //уничтожаем обьект
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);       //положение для перемещения пули
        
    }
}
