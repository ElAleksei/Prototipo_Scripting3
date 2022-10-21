using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Attack : State
{


    public override void OnEnter()
    {

    }

    public override void OnUpdate()
    {
        m_Enemy.Life = m_Enemy.Life - m_Player.Damage;
        m_fsm.SetState(m_fsm.m_Idle);
    }

    public override void OnExit()
    {

    }


}
