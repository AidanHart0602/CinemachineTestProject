using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject _orbitalCamera;
    [SerializeField]
    private GameObject _3DCamera;
    [SerializeField]
    private CharacterController _controller;
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _rotateSpeed;
    private Vector3 _direction;

    void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");
        _direction = new Vector3(0, 0, _vertical);
        _direction *= _moveSpeed * Time.deltaTime;
        _controller.Move(_direction);

        Vector3 rotation = new Vector3(0, _horizontal * _rotateSpeed * Time.deltaTime, 0);
        this.transform.Rotate(rotation);

        if (Input.GetMouseButtonDown(1))
        {
            _3DCamera.SetActive(false);
            _orbitalCamera.SetActive(true);
        }
        else if(Input.GetMouseButtonUp(1))
        {
            _3DCamera.SetActive(true);
           _orbitalCamera.SetActive(false);
        }
    }
}
