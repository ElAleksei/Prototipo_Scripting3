using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Attack : State
{
    GameObject BloodParticles;
    GameObject m_InstantiateBlood;
    GameObject SwordAudio;
    AudioSource m_SwordSound;

    IEnumerator Slash;

    public override void OnEnter()
    {
        Slash = SlashOff();
    }

    /// <summary>
    /// Se cargan todos los elementos de particulas y sonidos para el ataque
    /// Se hace el daño al enemigo
    /// </summary>
    public override void OnUpdate()
    {
        SwordAudio = GameObject.Find("SwordSFX");
        m_SwordSound = SwordAudio.GetComponent<AudioSource>();

        BloodParticles = Resources.Load("AttackParticles") as GameObject;
        m_InstantiateBlood = Instantiate(BloodParticles, null, true);
        Vector3 Pos = Pathfinding.tilemap.CellToWorld(Idle.m_V2_Target);
        m_InstantiateBlood.transform.position = Pos;

        m_SwordSound.Play();

        Vector3 SlashPos = Pos;
        SlashPos.y += 0.5f;
        Manager.Slash.transform.position = Camera.main.WorldToScreenPoint(SlashPos);
        Manager.SlashImage.enabled = true;
        StartCoroutine(Slash);

        if (Idle.AttackEnemy == true)
        {
            m_Enemy.Life = m_Enemy.Life - m_Player.Damage;
            Idle.AttackEnemy = false;
            m_fsm.SetState(m_fsm.m_Idle);
        }

        if (Idle.AttackEnemy2 == true)
        {
            m_Enemy2.Life = m_Enemy2.Life - m_Player.Damage;
            Idle.AttackEnemy2 = false;
            m_fsm.SetState(m_fsm.m_Idle);
        }
        
    }

    public override void OnExit()
    {

    }

    /// <summary>
    /// Funcion para desactivar el canvas del slash
    /// </summary>
    /// <returns></returns>
    IEnumerator SlashOff()
    {
        yield return new WaitForSeconds(0.5f);
        Manager.SlashImage.enabled = false;
    }
}
