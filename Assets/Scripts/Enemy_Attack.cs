using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : State
{
    float m_Cooldown = 0;

    GameObject PlayerHurtAudio1;
    AudioSource m_PlayerHurtSound1;
    GameObject PlayerHurtAudio2;
    AudioSource m_PlayerHurtSound2;
    AudioSource [] m_PlayerSounds;

    GameObject BloodParticles;
    GameObject m_InstantiateBlood;
    Player m_ScenePlayer;

    public override void OnEnter()
    {
        m_ScenePlayer = FindObjectOfType<Player>();
    }
    public override void OnUpdate()
    {
        m_PlayerSounds = new AudioSource[2];
        PlayerHurtAudio1 = GameObject.Find("PlayerSFX1");
        m_PlayerHurtSound1 = PlayerHurtAudio1.GetComponent<AudioSource>();
        PlayerHurtAudio2 = GameObject.Find("PlayerSFX2");
        m_PlayerHurtSound2 = PlayerHurtAudio2.GetComponent<AudioSource>();
        m_PlayerSounds[0] = m_PlayerHurtSound1;
        m_PlayerSounds[1] = m_PlayerHurtSound2;

        m_Cooldown += Time.deltaTime;
        if (m_Cooldown > 1)
        {
            m_Cooldown = 0;
            m_Player.Life = m_Player.Life - m_Enemy.Damage;
            int RandomSound = Random.Range(0,m_PlayerSounds.Length);
            m_PlayerSounds[RandomSound].Play();

            BloodParticles = Resources.Load("AttackParticles") as GameObject;
            m_InstantiateBlood = Instantiate(BloodParticles, null, true);
            m_InstantiateBlood.transform.position = m_ScenePlayer.transform.position;
        }

        m_EnemyFSM.SetState(m_EnemyFSM.m_Enemy_Idle);
    }
    public override void OnExit()
    {

    }
}
