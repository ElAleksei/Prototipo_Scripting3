using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject[] Enemy_List;
    public static GameObject Slash;
    public static Image SlashImage;
    public static GameObject EnemySlash;
    public static Image EnemySlashImage;
    GameObject Player;

    bool Level1 = true;
    bool Level2 = false;

    private void Start()
    {
        Player = GameObject.Find("Player");
        Slash = GameObject.Find("Slash");
        SlashImage = Slash.GetComponent<Image>();
        SlashImage.enabled = false;

        EnemySlash = GameObject.Find("EnemySlash");
        EnemySlashImage = EnemySlash.GetComponent<Image>();
        EnemySlashImage.enabled = false;
    }

    void Update()
    {
        Enemy_List = GameObject.FindGameObjectsWithTag("Enemy");   
        
        //Revision de condicion de victoria
        if (Enemy_List.Length <= 0)
        {
            Application.Quit();
        }

        //Casos de cambio de nivel
        if (Idle.PlayerCellPosition == new Vector3Int(2, 1, 0) & Level2 == false)
        {
            Player.transform.position = Pathfinding.tilemap.CellToWorld(new Vector3Int(-28, -31, 0));
            Level2 = true;
            Level1 = false;
        }

        if (Idle.PlayerCellPosition == new Vector3Int(-28, -30, 0) & Level1 == false)
        {
            Player.transform.position = Pathfinding.tilemap.CellToWorld(new Vector3Int(2, 2, 0));
            Level2 = false;
            Level1 = true;
        }
    }
}
