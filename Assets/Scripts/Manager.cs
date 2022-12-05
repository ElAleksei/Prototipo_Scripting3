using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{
    public static GameObject[] Enemy_List;
    GameObject m_Enemy1;
    bool Condition1 = false;
    bool Condition2 = false;

    public static GameObject Slash;
    public static Image SlashImage;
    public static GameObject EnemySlash;
    public static Image EnemySlashImage;

    GameObject m_Player;
    public static FMSScripting3 m_Script;
    GameObject m_Enemy2;
    public static FSM_Enemy2 m_Script2;

    public Canvas m_MenuCanvas;
    public Canvas m_GameCanvas;
    public Canvas m_FinalCanvas;
    public Canvas m_PauseCanvas;
    public Canvas m_VictoryCanvas;

    public GameObject m_PlayerNameField;
    public TextMeshProUGUI m_PlayerName;

    bool Level1 = true;
    bool Level2 = false;

    GameObject VictorySoundObject;
    AudioSource m_VictorySource;

    private void Start()
    {
        Enemy_List = new GameObject[2];
        m_Enemy1 = GameObject.Find("Enemy");

        //Desactivar los scripts de comportamiento
        m_Player = GameObject.Find("Player");
        m_Script = m_Player.GetComponent<FMSScripting3>();
        m_Script.enabled = false;

        m_Enemy2 = GameObject.Find("Enemy2");
        m_Script2 = m_Enemy2.GetComponent<FSM_Enemy2>();
        m_Script2.enabled = false;


        //Buscar los canvas de tajos
        Slash = GameObject.Find("Slash");
        SlashImage = Slash.GetComponent<Image>();
        SlashImage.enabled = false;

        EnemySlash = GameObject.Find("EnemySlash");
        EnemySlashImage = EnemySlash.GetComponent<Image>();
        EnemySlashImage.enabled = false;


        //Desactivar los canvas
        m_GameCanvas.enabled = false;
        m_MenuCanvas.enabled = true;
        m_FinalCanvas.enabled = false;
        m_PauseCanvas.enabled = false;
        m_VictoryCanvas.enabled = false;

        Enemy_List[0] = m_Enemy1;
        Enemy_List[1] = m_Enemy2;

        VictorySoundObject = GameObject.Find("VictorySound");
        m_VictorySource = m_VictorySource.GetComponent<AudioSource>();
    }

    void Update()
    {
        m_PlayerName = m_PlayerNameField.gameObject.GetComponent<TextMeshProUGUI>();
        m_PlayerName.text = Player.m_NameText.text;  
        
        if (Input.GetKeyDown(KeyCode.Escape) & Condition1 == false & Condition2 == false)
        {
            if (m_PauseCanvas.enabled == true)
            {
                OnResume();
            }

            if (m_PauseCanvas.enabled == false & m_MenuCanvas.enabled == false)
            {
                m_Script.enabled = false;
                m_PauseCanvas.enabled = true;
                m_GameCanvas.enabled = false;
                m_MenuCanvas.enabled = false;
            }           
        }

        //Revision de condicion de victoria
        
        if (Enemy_List[0] == null)
        {
            Condition1 = true;
        }
        if (Enemy_List[1] == null)
        {
            Condition2 = true;
        }
        if (Condition1 == true & Condition2 == true)
        {
            m_Script.enabled = false;
            m_GameCanvas.enabled = false;
            m_VictorySource.Play();
            m_VictoryCanvas.enabled = true;
        }

        //Casos de cambio de nivel
        if (Idle.PlayerCellPosition == new Vector3Int(2, 1, 0) & Level2 == false)
        {
            m_Player.transform.position = Pathfinding.tilemap.CellToWorld(new Vector3Int(-28, -31, 0));
            Level2 = true;
            Level1 = false;
        }

        if (Idle.PlayerCellPosition == new Vector3Int(-28, -30, 0) & Level1 == false)
        {
            m_Player.transform.position = Pathfinding.tilemap.CellToWorld(new Vector3Int(2, 2, 0));
            Level2 = false;
            Level1 = true;
        }
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnResume()
    {
        m_Script.enabled = true;
        m_PauseCanvas.enabled = false;
        m_GameCanvas.enabled = true;
        m_MenuCanvas.enabled = false;
    }
}
