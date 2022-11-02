using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: Characters
{
    public Player m_player;
    public SpriteRenderer m_spriteRenderer;

    [SerializeField]
    private int m_Energy;

    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        m_player = GetComponent<Player>();
        m_player.Life = 10;
        m_player.Damage = 1;

        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        healthbar.SetBar(m_player.Life);

        if (m_player.Life <= 0)
        {
            Destroy(gameObject);
            Application.Quit();
        }

    }

    public void UpdateSprite(Vector2 LastPos, Vector2 CurrentPos)
    {
        Debug.Log(LastPos);
        Debug.Log(CurrentPos);
        //Ariba derecha
        if (CurrentPos.x > LastPos.x & CurrentPos.y > LastPos.y)
        {
            m_spriteRenderer.sprite = Resources.Load("Character_Change_7") as Sprite;
        }

        //Arriba izquierda
        if (CurrentPos.x < LastPos.x & CurrentPos.y > LastPos.y)
        {
            m_spriteRenderer.sprite = Resources.Load("Character_Change_1") as Sprite;
        }

        //Abajo izquierda
        if (CurrentPos.x < LastPos.x & CurrentPos.y < LastPos.y)
        {
            m_spriteRenderer.sprite = Resources.Load("Character_Change_3") as Sprite;
        }

        //Abajo derecha
        if (CurrentPos.x > LastPos.x & CurrentPos.y < LastPos.y)
        {
            m_spriteRenderer.sprite = Resources.Load("Character_Change_5") as Sprite;
        }
    }
}
