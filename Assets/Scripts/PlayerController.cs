using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementspeed = 1f;
    private Vector2 movementValue;

    
    void Update()
    {
        MovementSystem();
    }
    private void Move(Vector3 position)
    {
        transform.position += position * (movementspeed * Time.deltaTime);
    }

    private void MovementSystem()
    {
        Move(new Vector3(movementValue.x, 0, movementValue.y));
    }

    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>();
    }
}
