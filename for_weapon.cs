using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;     //��������
    public float lifetime;      //����� ����
    public float distance;      //��������� �� �����
    public int damage;          //���� ����
    public LayerMask whatIs;        //��� ������� �������



    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIs);   //������ ��� ����� �������
        if (hitInfo.collider != null)       //��������� ��������
        {
            if(hitInfo.collider.CompareTag("Enemy"))        //�������� �� ���� Enemy
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);  //�������� ��������� Enemy � ��� ����
            }
            Destroy(gameObject);        //���������� ������
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);       //��������� ��� ����������� ����
        
    }
}
