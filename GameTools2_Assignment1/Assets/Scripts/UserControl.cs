﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserControl : MonoBehaviour
{

    private float m_turn;
    private float m_forward;
    private bool m_jump;
  
    private Character m_character;

    private void Start()
    {
        m_character = GetComponent<Character>();
    }
    // Use this for initialization

    void FixedUpdate()
    {
        // Get Inputs
        m_turn = Input.GetAxis("Horizontal");
        m_forward = Input.GetAxis("Vertical");
        m_jump = Input.GetButtonDown("Jump");


        m_character.Move(m_turn, m_forward, m_jump);

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Scene001");
        }
    }


   


}
