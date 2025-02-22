using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTopDownMovingSystem : MonoBehaviour
{
    private float PlayerMoveSpeed = 5f; //создание переменной для управления скоростью передвижения персонажа
    private Vector2 MoveDirection; //определение направления движения игрока в двух плоскостях x и y
    private Rigidbody2D rb; //физическая часть игрока, которая отвечает за коллизию, передвижение и еще за что-то

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //получение компонента Rigidbody с игрока
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
