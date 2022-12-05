using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_Enemy2 : State
{
    public State m_Enemy2_Current;
    public State m_Enemy2_Idle;
    public State m_Enemy2_Move;
    public State m_Enemy2_Attack;

    // Start is called before the first frame update
    void Start()
    {

        m_Enemy2_Idle = gameObject.AddComponent<Enemy2_Idle>();
        m_Enemy2_Attack = gameObject.AddComponent<Enemy2_Attack>();
        m_Enemy2_Move = gameObject.AddComponent<Enemy2_Move>();

        m_Enemy2_Idle.SetEnemy2FSM(this);
        m_Enemy2_Attack.SetEnemy2FSM(this);
        m_Enemy2_Move.SetEnemy2FSM(this);

        m_Enemy2_Current = m_Enemy2_Idle;
        m_Enemy2_Current.OnEnter();
    }

    //Update is called once per frame
    void Update()
    {
        m_Enemy2_Current.OnUpdate();
    }

    public void SetState(State CurrentState)
    {
        m_Enemy2_Current.OnExit();
        m_Enemy2_Current = CurrentState;
        m_Enemy2_Current.OnEnter();
    }
}
