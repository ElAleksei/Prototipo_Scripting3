using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Characters
{
    public Enemy m_Enemy;
    GameObject SkeletonAudio;
    AudioSource m_SkeletonSound;

    // Start is called before the first frame update
    void Start()
    {
        m_Enemy = GetComponent<Enemy>();
        m_Enemy.Life = 5;
        m_Enemy.Damage = 1;

        SkeletonAudio = GameObject.Find("SkeletonDeathSFX");
        m_SkeletonSound = SkeletonAudio.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Enemy.Life <= 0)
        {
            PotionsDisplay.CreatePotion(Enemy_Idle.m_EnemyCellPosition);
            m_SkeletonSound.Play();
            Destroy(gameObject);
            Enemy_Idle.m_EnemyCellPosition = new Vector3Int(0, 0, 20);
        }
    }
}
