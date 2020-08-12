using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum e_State
{
    None,
    Stern,
    Die,
    Jump,
    Rush,
}

public class Player : MonoBehaviour
{
    
    public GameObject[] particles;
    public GameObject particlePos;

    private e_State playerState;

    private void Start()
    {
     
    }
    void Update()
    {
       animation.
    }

    public e_State getState()
    {
        return playerState;
    }
    public void SetState_None()
    {
        playerState = e_State.None;
    }

    public void SetState_Die()
    {
        playerState = e_State.Die;
        Destroy(this.gameObject);
        
    }
    public void SetState_Stern()
    {
        playerState = e_State.Stern;
     
    }
    public void SetState_Jump()
    {
        playerState = e_State.Jump;
       
    }

    public void SetState_Rush()
    {
        playerState = e_State.Rush;
        
    }

 





}
