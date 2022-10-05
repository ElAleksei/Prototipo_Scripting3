using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public FMSScripting3 m_fsm;
    public void SetFSM(FMSScripting3 StateMachine)
    {
        m_fsm = StateMachine;
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

}
