using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    public float m_rushDistance = 1.5f;
    public float m_rushSpeed = 3f;
    public Vector3 m_target;
    public float pushPower = 1.5F;
    public float rushTime = 1.5f;

    private Player m_player;
    private CharacterController character;
    void Start()
    {
        m_player = GetComponent<Player>();
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            m_player.SetState_Rush();
            
        }
       
        Push();
    }

    public void Rush()
    {
        character.Move(transform.forward * m_rushSpeed * Time.deltaTime);   
    }

    public void Push()
    {
        transform.position = Vector3.MoveTowards(transform.position, m_target,0.01f );
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Player")
        {

          
            hit.gameObject.GetComponent<PlayerSkill>().ChangeTarget(Vector3.forward);
        }
      
    }

    public void ChangeTarget(Vector3 dir)
    {
        m_target = transform.TransformDirection(dir * pushPower) + transform.position;
    }

   

}
