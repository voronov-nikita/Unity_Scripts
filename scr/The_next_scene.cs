using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //���������� ���. ����������

public class perehod : MonoBehaviour
{

    public void NextLevel(int _sceanNumber)     //������� ����� ������������� �����, �������� �������� ( ������ ) ����
    {
        SceneManager.LoadScene(_sceanNumber);       //����� ����� �������
    }
    //��������! ��������� ������� ����� UI Canvas(Button) � �������� �� ����� GameObject ������ ������, ����� ������� ����� ������ � ������.
}
