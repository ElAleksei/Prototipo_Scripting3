using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : State
{
    float m_Cooldown = 0;
    GameObject BloodParticles;
    GameObject m_InstantiateBlood;
    Player m_ScenePlayer;
    public override void OnEnter()
    {
        m_ScenePlayer = FindObjectOfType<Player>();
    }
    public override void OnUpdate()
    {
        
        
        m_Cooldown += Time.deltaTime;
        if (m_Cooldown > 1)
        {
            m_Cooldown = 0;
            m_Player.Life = m_Player.Life - m_Enemy.Damage;

            BloodParticles = Resources.Load("AttackParticles") as GameObject;
            m_InstantiateBlood = Instantiate(BloodParticles, null, true);
            m_InstantiateBlood.transform.position = m_ScenePlayer.transform.position;
        }

        m_EnemyFSM.SetState(m_EnemyFSM.m_Enemy_Idle);
    }
    public override void OnExit()
    {

    }
}
