using System.Collections;
using System.Collections.Generic;
using InputController;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharactereMovement : MonoBehaviour
{
    [SerializeField] InputActionReference _move;
    [SerializeField] Animator _animator;


    void Update()
    {
        Vector2 value = _move.action.ReadValue<Vector2>();
        float speed = value.magnitude;
        speed = Mathf.Clamp(value: speed, min: 0f, max: 1f);
        _animator.SetFloat("Speed", speed);
    }
}
