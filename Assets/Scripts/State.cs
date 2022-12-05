using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public FMSScripting3 m_fsm;
    public FSM_Enemy m_EnemyFSM;
    public FSM_Enemy2 m_Enemy2FSM;

    public static Enemy m_Enemy;
    public static Enemy2 m_Enemy2;
    public static Player m_Player;
    public void Awake()
    {
        Pathfinding.Initialize();
        m_Enemy2 = GameObject.Find("Enemy2").GetComponent<Enemy2>();
        m_Enemy = GameObject.Find("Enemy").GetComponent<Enemy>();
        m_Player = GameObject.Find("Player").GetComponent<Player>();
    }

    public void SetFSM(FMSScripting3 StateMachine)
    {
        m_fsm = StateMachine;
    }

    public void SetEnemyFSM(FSM_Enemy EnemyStateMachine)
    {
        m_EnemyFSM = EnemyStateMachine;
    }

    public void SetEnemy2FSM(FSM_Enemy2 Enemy2StateMachine)
    {
        m_Enemy2FSM = Enemy2StateMachine;
    }

    public virtual void OnUpdate()
    {

    }
    public virtual void OnEnter()
    {

    }

    public virtual void OnExit()
    {

    }

    public virtual void Attacking(int Life, int Damage)
    {
        Life = Life - Damage;
    }

}
