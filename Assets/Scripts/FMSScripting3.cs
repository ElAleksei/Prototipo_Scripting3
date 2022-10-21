using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMSScripting3 : State
{

    public State m_Current;
    public State m_Idle;
    public State m_Move;
    public State m_Attack;

    public List<Vector2> m_path;

    // Start is called before the first frame update
    void Start()
    {
        

        m_Idle = gameObject.AddComponent<Idle>();
        m_Attack = gameObject.AddComponent<Attack>();
        m_Move = gameObject.AddComponent<Move>();

        m_Idle.SetFSM(this);
        m_Attack.SetFSM(this);
        m_Move.SetFSM(this);

        m_Current = m_Idle;
        m_Current.OnEnter();
    }

     //Update is called once per frame
    void Update()
    {
        m_Current.OnUpdate();
    }

    public void SetState(State CurrentState)
    {
        m_Current.OnExit();
        m_Current = CurrentState;
        m_Current.OnEnter();
    }

}
