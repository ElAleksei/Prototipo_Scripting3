using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_Enemy : State
{
    public State m_Enemy_Current;
    public State m_Enemy_Idle;
    public State m_Enemy_Move;
    public State m_Enemy_Attack;

    // Start is called before the first frame update
    void Start()
    {
        
        m_Enemy_Idle = gameObject.AddComponent<Enemy_Idle>();
        m_Enemy_Attack = gameObject.AddComponent<Enemy_Attack>();
        m_Enemy_Move = gameObject.AddComponent<Enemy_Move>();

        m_Enemy_Idle.SetEnemyFSM(this);
        m_Enemy_Attack.SetEnemyFSM(this);
        m_Enemy_Move.SetEnemyFSM(this);

        m_Enemy_Current = m_Enemy_Idle;
        m_Enemy_Current.OnEnter();
    }

    //Update is called once per frame
    void Update()
    {
        m_Enemy_Current.OnUpdate();
    }

    public void SetState(State CurrentState)
    {
        m_Enemy_Current.OnExit();
        m_Enemy_Current = CurrentState;
        m_Enemy_Current.OnEnter();
    }
}
