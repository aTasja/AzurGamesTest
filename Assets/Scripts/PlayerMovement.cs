using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 2;
    [SerializeField] private Camera _camera;
    
    private CharacterController _characterController;
    private Animator _animator;
    private string _speed = "Speed";
    private float _minXpos = -3f;
    private float _maxXpos = 3f;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) {
            FollowMousePositionX();
            Move();
        }
        else {
            Stop();
        }
    }
    
    private void Move()
    {
        _animator.SetFloat(_speed, MovementSpeed);
        _characterController.Move(Vector3.forward * MovementSpeed * Time.deltaTime);
    }

    private void FollowMousePositionX()
    {
        var ray =_camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (!Physics.Raycast(ray, out hit)) return;

        var pos = transform.position;
        var clampedPosX = Mathf.Clamp(hit.point.x, _minXpos, _maxXpos);
        var target = new Vector3(clampedPosX, pos.y, pos.z);
        transform.position = Vector3.MoveTowards(pos, target,  MovementSpeed * Time.deltaTime);

    }

    private void Stop() => _animator.SetFloat(_speed, 0);
}
