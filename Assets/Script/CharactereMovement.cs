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

    [SerializeField] CustomControllers _controls;

    [SerializeField] Camera _camera;

    private Vector3 _directionMovement;

   

    void Update()
    {

        //Movement joueur
        Vector3 value = _move.action.ReadValue<Vector2>();
        float speed = value.magnitude;
        speed = Mathf.Clamp(value: speed, min: 0f, max: 1f);


        _animator.SetFloat("speed",speed);

        //Movement cam
        Vector3 moveVector = new Vector3(value.x, 0, value.y);
        _cc.Move(moveVector * speed * Time.deltaTime);
        //_cc.transform.Translate(0, 0, speed * Time.deltaTime);
        _cc.transform.rotation = Quaternion.Euler(0,_camera.transform.rotation.eulerAngles.y,0);

        //Vector3 directionRotation = Quaternion.LookRotation((_directionMovement, Vector3.up) * Quaternion.LookRotation(moveVector, Vector3.up));
        //Vector3 rotation = Quaternion.Lerp(transform.rotation, directionRotation * Time.deltaTime);
        //
        //transform.rotation = rotation;



        



    }
}
