using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    public float m_moveSpeed = 2.0f;
    public float m_jumpPower = 5.0f;
    public float m_rotationSpeed = 2.0f;
    public float m_gravity = 9.8f;
   
    //private
    public CharacterController m_controller;
    public bool m_isJump = false;
    private Vector3 m_playerVelocity;
    public bool isGround;
    private Player m_player;
    private Vector3 m_DistanceVec;
 
    void Start()
    {
        m_controller = this.GetComponent<CharacterController>();
        m_player = this.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
        PlayerMove();

        PlayerRotate();
        
    }

    void PlayerMove()
    {
        isGround = m_controller.isGrounded;

        if (!isGround)
        {
            m_playerVelocity.y -= m_gravity * Time.deltaTime;
        }
        else if (m_player.m_playerState == e_State.None)
        {
            
            m_playerVelocity = new Vector3(Input.GetAxis("Horizontal") * m_moveSpeed, 0, Input.GetAxis("Vertical") * m_moveSpeed);
            m_playerVelocity = transform.TransformDirection(m_playerVelocity);
            
            
            
        }
        else if (m_player.m_playerState != e_State.Rush)
        {
            m_playerVelocity.y = 0.0f;
            m_isJump = false;
            m_player.m_playerState = e_State.None;

        }

        if (Input.GetButton("Jump") && !m_isJump && m_player.m_playerState == e_State.None )
        {
            m_isJump = true;
            m_player.m_playerState = e_State.Jump;
            m_playerVelocity.y = m_jumpPower;
        }

        m_controller.Move(m_playerVelocity * Time.deltaTime );
    }

  
  

    void PlayerRotate()
    {
        if (m_player.m_playerState != e_State.Rush)
        {
            float x = Input.GetAxis("Mouse X") * -m_rotationSpeed;
            transform.Rotate(0, x, 0);
        }
    }
}
