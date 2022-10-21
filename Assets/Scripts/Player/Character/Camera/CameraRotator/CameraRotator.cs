using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{ 
    [SerializeField] private float _smoothTime;
    [SerializeField] private Vector2 _rotationLimit;
    [SerializeField] private float _mouseSensitivity; 
    private Vector3 _currentRotation;
    private Vector3 _smoothVelocity = Vector3.zero;
    private Transform _transform;
    private float _rotationY;
    private float _rotationX;
    private void Awake()
    {
        _transform = transform;
    }

    public void Rotating()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity;

        _rotationY += mouseX;
        _rotationX += mouseY;
        _rotationX = Mathf.Clamp(_rotationX, _rotationLimit.x, _rotationLimit.y);
        
        Vector3 nextRotation = new(_rotationX, _rotationY);
        _currentRotation = Vector3.SmoothDamp(_currentRotation, nextRotation, ref _smoothVelocity, _smoothTime);
        _transform.localEulerAngles = _currentRotation;
    }
}
