using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float force = 10;

    [SerializeField] private Rigidbody2D _rigidbody2D;

    [SerializeField] private Animator _animator;

    private bool playerhit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton((0)))
        {
            _rigidbody2D.velocity = Vector2.up* force;
            _animator.SetBool("flay",true);
        }
        else
        {
            _animator.SetBool("flay",false);
        }
    }

    
    private void OnTriggerExit2D(Collider2D other)
    {
        _animator.SetBool("hit",false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        _animator.SetBool("hit",true);
    }

}
