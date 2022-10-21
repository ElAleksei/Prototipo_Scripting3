using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public FMSScripting3 m_fsm;
    public FSM_Enemy m_EnemyFSM;

    public static Enemy m_Enemy;
    public static Player m_Player;
    public void Awake()
    {
        Pathfinding.Initialize();
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
