using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2_Idle : State
{
    public static Vector3Int m_Enemy2CellPosition;

    public float m_Enemy2AttackRange = 1f;
    public float m_Enemy2Range = 4f;
    public static float m_Distance2;

    public static float m_Cooldown;

    public override void OnEnter()
    {
        m_Enemy2CellPosition = Pathfinding.tilemap.WorldToCell(transform.position);
        m_Cooldown = 0;
    }

    public override void OnUpdate()
    {
        //Distancia entre el enemigo y el jugador
        m_Distance2 = (m_Enemy2CellPosition - Idle.PlayerCellPosition).magnitude;
        m_Distance2 = Mathf.Abs(m_Distance2);

        m_Cooldown += Time.deltaTime;

        if (m_Distance2 <= m_Enemy2AttackRange)
        {
            m_Enemy2FSM.SetState(m_Enemy2FSM.m_Enemy2_Attack);
        }

        if (m_Cooldown > 5)
        {
            m_Enemy2FSM.SetState(m_Enemy2FSM.m_Enemy2_Move);
        }
    }
    public override void OnExit()
    {

    }
}
