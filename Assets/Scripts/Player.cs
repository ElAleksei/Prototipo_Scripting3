using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player: Characters
{
    public Player m_player;
    public SpriteRenderer m_spriteRenderer;

    [SerializeField]
    private int m_Energy;

    public HealthBar healthbar;

    public string m_Player_Name;

    public static TextMeshProUGUI m_NameText;
    public GameObject m_InputText;

    GameObject PlayerAudio;
    AudioSource m_PlayerSound;

    public Canvas m_Canvas;

    // Start is called before the first frame update
    void Start()
    {
        m_player = GetComponent<Player>();
        m_player.Life = 10;
        m_player.Damage = 1;
        m_player.MaxLife = 10;

        m_spriteRenderer = GetComponent<SpriteRenderer>();

        PlayerAudio = GameObject.Find("PlayerDeathSFX");
        m_PlayerSound = PlayerAudio.GetComponent<AudioSource>();

        m_NameText = new TextMeshProUGUI();
        m_NameText.text = "A";
    }
    void Update()
    {       
        m_NameText = m_InputText.gameObject.GetComponent<TextMeshProUGUI>();

        healthbar.SetBar(m_player.Life);

        if (m_player.Life <= 0)
        { 
            m_PlayerSound.Play();
            m_Canvas.enabled = true;
            Manager.m_Script.enabled = false;
            //Destroy(gameObject);
            //Application.Quit();
        }

    }

    /// <summary>
    /// Se actualiza el sprite del jugador dependiendo del movimiento
    /// </summary>
    /// <param name="LastPos"></param> Anterior posicion del jugador
    /// <param name="CurrentPos"></param> Actuak posicion del jugador
    public void UpdateSprite(Vector2 LastPos, Vector2 CurrentPos)
    {
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
