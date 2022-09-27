using System.Collections;
using System.Collections.Generic;
using InputController;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharactereMovement : MonoBehaviour
{
    [SerializeField] InputActionReference _move;
    [SerializeField] Animator _animator;
    [SerializeField] float _speed;
    [SerializeField] CharacterController _cc;

    private void Start()
    {
        
    }

    void Update()
    {
        Vector3 value = _move.action.ReadValue<Vector2>();
        float speed = value.magnitude;
        speed = Mathf.Clamp(value: speed, min: 0f, max: 1f);
        _animator.SetFloat("Speed", speed);

        _cc.transform.Translate(0, 0, speed * Time.deltaTime);

        

        



    }
}
