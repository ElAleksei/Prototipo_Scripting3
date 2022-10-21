using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : State
{
    float m_Cooldown = 0;
    public override void OnEnter()
    {

    }
    public override void OnUpdate()
    {
        
        
        m_Cooldown += Time.deltaTime;
        if (m_Cooldown > 1)
        {
            m_Cooldown = 0;
            m_Player.Life = m_Player.Life - m_Enemy.Damage;
        }

        m_EnemyFSM.SetState(m_EnemyFSM.m_Enemy_Idle);
    }
    public override void OnExit()
    {

    }
}
