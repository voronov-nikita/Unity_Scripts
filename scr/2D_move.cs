using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heros : MonoBehaviour
{
    public float speed;             //задать скорость
    public float jump;              //задать прыжок
    private float moveInput;        //считаем скорость

    private Rigidbody2D rb;     //Rigidbody

    private bool isGround;          //касание земли(правда или ложь)
    public Transform GroundCheck;       //GameObject задаем для считывания isGround
    public float radius;            //задаем радиус касания к земле _*Не делать большим, ставить 0,5*_
    public LayerMask whatIsGround;          //задает на каком слое находится наша платформа от персонажа _*Ground - слой платформы; Defeult - слой персонажа*_

    private bool FacingRight = true;        //для переворота лица персонажа



    private int extraJump;      //проверка на земле ли персонаж, требуется новый GameObject
    public int maxJump;     //максимум прыжков( 0 =1, 1=2 и т.д)
  
    void Start()
    {
        extraJump = maxJump;        //упрощаем переменную
        rb = GetComponent<Rigidbody2D>();               // нужен Rigidbody для взаимодействий при движении
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");        //движение по горизонтали
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);     //по оси х скорость умноженное на перемещение   


        if (FacingRight == false && moveInput > 0)         //лицо  и движение в одну сторону
        {
            Flip();                                 //отсылка на метод Flip
        }else if ( FacingRight == true && moveInput < 0)        //сохранить значение лица по положению координат
        {
            Flip();
        }


        isGround = Physics2D.OverlapCircle(GroundCheck.position, radius, whatIsGround);     //что такое isGround
    }


    void Flip()          //метод для переворота лица
    {
        FacingRight = !FacingRight;     //переворачиваем лицо координатами
        Vector3 Scaler = transform.localScale;      //scale - трехмерная величина
        Scaler.x *= -1;                     //scale переворачиваем по оси х (1=-1)
        transform.localScale = Scaler;          //получаем значение
    }

    void Update()
    {
        if (isGround  == true)              //условие прыжка если косаемся земли("isGround")
        {
            extraJump = maxJump;            //точно передаем значение
        }


        if(Input.GetKeyDown(KeyCode.Space) && extraJump > 0)        //если нажимаем (Input) кнопку Space (KeyCode.Space) и макс.прыжков больше 0
        {
            rb.velocity = Vector2.up * jump;        //делаем прыжок
            extraJump--;                          //вычитаем значение из проверки 
        }else if(Input.GetKeyDown(KeyCode.Space) && extraJump ==0 && isGround == true)      //иначе если нажат Space и значение проверки равно 0 и мы касаемся зесли 
        {
            rb.velocity = Vector2.up * jump;        //разрешаем прыжок
        }
    }
}
