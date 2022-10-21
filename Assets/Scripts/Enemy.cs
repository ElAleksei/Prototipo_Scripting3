using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Characters
{
    public Enemy m_Enemy;

    // Start is called before the first frame update
    void Start()
    {
        m_Enemy = GetComponent<Enemy>();
        m_Enemy.Life = 5;
        m_Enemy.Damage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Enemy.Life <= 0)
        {
            Destroy(gameObject);
            Enemy_Idle.m_EnemyCellPosition = new Vector3Int(0, 0, 20);
        }
    }
}
