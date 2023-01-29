using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //подключаем доп. библеотеку

public class perehod : MonoBehaviour
{

    public void NextLevel(int _sceanNumber)     //создаем новый целочисленный метод, мен€ющий значение ( номера ) сцен
    {
        SceneManager.LoadScene(_sceanNumber);       //какую сцену открыть
    }
    //¬нимание! требуетс€ создать новый UI Canvas(Button) и добавить на новый GameObject данный скрипт, далее добавит новый обьект в кнопку.
}
