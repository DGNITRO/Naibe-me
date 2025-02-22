using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTopDownMovingSystem : MonoBehaviour
{
    private float PlayerMoveSpeed = 5f; //�������� ���������� ��� ���������� ��������� ������������ ���������
    private Vector2 MoveDirection; //����������� ����������� �������� ������ � ���� ���������� x � y
    private Rigidbody2D rb; //���������� ����� ������, ������� �������� �� ��������, ������������ � ��� �� ���-��

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //��������� ���������� Rigidbody � ������
    }

    void Update()
    {
        rb.velocity = MoveDirection * PlayerMoveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        MoveDirection = context.ReadValue<Vector2>(); 
    }
}
