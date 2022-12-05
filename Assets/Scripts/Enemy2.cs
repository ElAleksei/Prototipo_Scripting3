using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Characters
{
    public Enemy2 m_enemy2;
    public SpriteRenderer m_EnemyspriteRenderer;
    public GameObject m_KirbyObject;
    public AudioSource m_KirboSound;
    // Start is called before the first frame update
    void Start()
    {
        m_enemy2 = GetComponent<Enemy2>();
        m_enemy2.Life = 5;
        m_enemy2.Damage = 2;
        m_EnemyspriteRenderer = GetComponent<SpriteRenderer>();

        m_KirbyObject = GameObject.Find("KirbyDeath");
        m_KirboSound = m_KirbyObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_enemy2.Life <= 0)
        {
            //PotionsDisplay.CreatePotion(Enemy_Idle.m_EnemyCellPosition);
            m_KirboSound.Play();
            Destroy(gameObject);
            //Enemy_Idle.m_EnemyCellPosition = new Vector3Int(0, 0, 20);
        }
    }

    public void UpdateEnemySprite(Vector2 LastPos, Vector2 CurrentPos)
    {
        //Izquierda arriba
        if (CurrentPos.x < LastPos.x & CurrentPos.y > LastPos.y)
        {
            m_EnemyspriteRenderer.sprite = Resources.Load("Kirbito_0") as Sprite;
        }

        //Derecha arriba
        if (CurrentPos.x > LastPos.x & CurrentPos.y > LastPos.y)
        {
            m_EnemyspriteRenderer.sprite = Resources.Load("Kirbito_9") as Sprite;
        }

        //Izquierda abajo
        if (CurrentPos.x < LastPos.x & CurrentPos.y < LastPos.y)
        {
            m_EnemyspriteRenderer.sprite = Resources.Load("Kirbito_2") as Sprite;
        }

        //Derecha abajo
        if (CurrentPos.x > LastPos.x & CurrentPos.y < LastPos.y)
        {
            m_EnemyspriteRenderer.sprite = Resources.Load("Kirbito_5") as Sprite;
        }
    }
}
