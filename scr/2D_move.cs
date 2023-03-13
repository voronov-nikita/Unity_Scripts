using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heros : MonoBehaviour
{
    public float speed;             //������ ��������
    public float jump;              //������ ������
    private float moveInput;        //������� ��������

    private Rigidbody2D rb;     //Rigidbody

    private bool isGround;          //������� �����(������ ��� ����)
    public Transform GroundCheck;       //GameObject ������ ��� ���������� isGround
    public float radius;            //������ ������ ������� � ����� _*�� ������ �������, ������� 0,5*_
    public LayerMask whatIsGround;          //������ �� ����� ���� ��������� ���� ��������� �� ��������� _*Ground - ���� ���������; Defeult - ���� ���������*_

    private bool FacingRight = true;        //��� ���������� ���� ���������



    private int extraJump;      //�������� �� ����� �� ��������, ��������� ����� GameObject
    public int maxJump;     //�������� �������( 0 =1, 1=2 � �.�)
  
    void Start()
    {
        extraJump = maxJump;        //�������� ����������
        rb = GetComponent<Rigidbody2D>();               // ����� Rigidbody ��� �������������� ��� ��������
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");        //�������� �� �����������
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);     //�� ��� � �������� ���������� �� �����������   


        if (FacingRight == false && moveInput > 0)         //����  � �������� � ���� �������
        {
            Flip();                                 //������� �� ����� Flip
        }else if ( FacingRight == true && moveInput < 0)        //��������� �������� ���� �� ��������� ���������
        {
            Flip();
        }


        isGround = Physics2D.OverlapCircle(GroundCheck.position, radius, whatIsGround);     //��� ����� isGround
    }


    void Flip()          //����� ��� ���������� ����
    {
        FacingRight = !FacingRight;     //�������������� ���� ������������
        Vector3 Scaler = transform.localScale;      //scale - ���������� ��������
        Scaler.x *= -1;                     //scale �������������� �� ��� � (1=-1)
        transform.localScale = Scaler;          //�������� ��������
    }

    void Update()
    {
        if (isGround  == true)              //������� ������ ���� �������� �����("isGround")
        {
            extraJump = maxJump;            //����� �������� ��������
        }


        if(Input.GetKeyDown(KeyCode.Space) && extraJump > 0)        //���� �������� (Input) ������ Space (KeyCode.Space) � ����.������� ������ 0
        {
            rb.velocity = Vector2.up * jump;        //������ ������
            extraJump--;                          //�������� �������� �� �������� 
        }else if(Input.GetKeyDown(KeyCode.Space) && extraJump ==0 && isGround == true)      //����� ���� ����� Space � �������� �������� ����� 0 � �� �������� ����� 
        {
            rb.velocity = Vector2.up * jump;        //��������� ������
        }
    }
}
