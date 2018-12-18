﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{

    private Animator m_animator;


    // Use this for initialization
    void Start()
    {
        // Initialize Animator
        m_animator = GetComponent<Animator>();
    }

    public void Move(float turn, float forward, bool jump)
    {
        m_animator.SetFloat("Turn", turn);
        m_animator.SetFloat("Forward", forward);


        if (jump)
        {
            m_animator.SetTrigger("Jump");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            m_animator.SetTrigger("Strike");
        }
    }
}