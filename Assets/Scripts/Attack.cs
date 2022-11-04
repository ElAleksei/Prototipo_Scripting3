using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Attack : State
{
    GameObject BloodParticles;
    GameObject m_InstantiateBlood;

    public override void OnEnter()
    {

    }

    public override void OnUpdate()
    {
        BloodParticles = Resources.Load("AttackParticles") as GameObject;
        m_InstantiateBlood = Instantiate(BloodParticles, null, true);
        Vector3 Pos = Pathfinding.tilemap.CellToWorld(Idle.m_V2_Target);
        m_InstantiateBlood.transform.position = Pos;

        m_Enemy.Life = m_Enemy.Life - m_Player.Damage;
        m_fsm.SetState(m_fsm.m_Idle);
    }

    public override void OnExit()
    {

    }


}
