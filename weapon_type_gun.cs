using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject patron;       //������ ������ ������ ������� �� ����� ��������
    public Transform shotpoint;     //������� ������� ������� ������ �� ����� �������� 

    private float timeSetgun;       //����� 
    public  float startTimeSet;         //�����������

    
    void Start()
    {
        
    }

    
    void Update()
    {   if(timeSetgun <= 0)         //������� ���� ����������� �� ����������
        {
            if (Input.GetKeyDown(KeyCode.R))            //���� ������ �� ������...
            {
                Instantiate(patron, shotpoint.position, transform.rotation);        //�������� ������, ������� ������ �� ��������, ��������� � ����� ������� ��������
                timeSetgun = startTimeSet;      //������������ �������� ����������� � ������� �����������
            }
        }
        else
        {
            timeSetgun -= Time.deltaTime;       //�������� ����������� �� ������� �����������
        }
        
    }
}
