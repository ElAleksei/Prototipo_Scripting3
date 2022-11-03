using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Enemy_Idle : State
{
    public static Vector3Int m_EnemyCellPosition;

    public float m_EnemyAttackRange = 1f;
    public float m_EnemyRange = 4f;
    public static float m_Distance;
    public override void OnEnter()
    {
        m_EnemyCellPosition = Pathfinding.tilemap.WorldToCell(transform.position);
    }
    public override void OnUpdate()
    {
        m_Distance = (m_EnemyCellPosition - Idle.PlayerCellPosition).magnitude;
        m_Distance = Mathf.Abs(m_Distance);

        if (m_Distance <= m_EnemyAttackRange)
        {
            m_EnemyFSM.SetState(m_EnemyFSM.m_Enemy_Attack);
        }
    }
    public override void OnExit()
    {

    }
}
