using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private static Player _instance;
    public static Player Instance => (_instance) ? _instance : _instance = FindObjectOfType<Player>();

    [SerializeField] private float _horizontalSpeed = 5;
    
    private Rigidbody2D _rb;
    private void Awake()
    {
        if (_instance) Destroy(gameObject);
        _instance = this;

        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontal = Math.Abs(Input.GetAxis("Horizontal"));
        if (Mathf.Abs(horizontal) > float.Epsilon)
        {
            _rb.AddForce(horizontal * _horizontalSpeed * Time.deltaTime * Vector2.right);
        }
    }
}
