using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Move : State
{


    public static bool Has_Tile;
    public static Vector3Int cellPosition;
    public static Vector3Int cellPath;

    public float MovingTime = 3;
    public float CurrentMovingTime;

    public float m_Tolerance = 0.2f;
    public float m_EnemyTolerance = 1f;
    public float m_Magnitud;

    public Box[] m_MoveBox_List;

    public Vector2 PlayerPos = new Vector2(3f,2.25f);
    public Vector2 NewPosition;
    public Vector2 CurrentPosition;

    public GameObject m_Player;
    public Player PlayerScript;

    public override void OnEnter()
    {
        m_MoveBox_List = GameObject.FindObjectsOfType<Box>();
        m_Player = GameObject.FindGameObjectWithTag("Player");
    }

    public override void OnUpdate()
    {
        CurrentMovingTime += Time.deltaTime;
        CurrentPosition = new Vector2(transform.position.x, transform.position.y);
        PlayerScript = m_Player.GetComponent<Player>();
        PlayerScript.UpdateSprite(PlayerPos,CurrentPosition);
        //
        PlayerPos = new Vector2(transform.position.x,transform.position.y);
        NewPosition = Vector2.Lerp(Idle.InitialPos, Idle.Target, CurrentMovingTime/MovingTime);
        cellPosition = Pathfinding.tilemap.WorldToCell(NewPosition);
        m_Magnitud = (PlayerPos - Idle.Target).magnitude;

        if (m_MoveBox_List != null)
        {
            for (int i = 0; i < m_MoveBox_List.Length; i++)
            {

                Box MoveCurrent_Box = m_MoveBox_List[i];

                if (Pathfinding.tilemap.HasTile(cellPosition) == true & Pathfinding.Is_Wall.HasTile(cellPosition) == false & Pathfinding.Is_Obstacle.HasTile(cellPosition) == false & Pathfinding.Is_Enemies.HasTile(cellPosition) == false & cellPosition != Enemy_Idle.m_EnemyCellPosition & MoveCurrent_Box.m_BoxPosition != cellPosition)
                {
                    transform.position = Pathfinding.tilemap.GetCellCenterWorld(cellPosition);

                }
                else
                {
                    m_Tolerance = 2f;
                }
            }
        }

        if (m_MoveBox_List.Length == 0)
        {
            if (Pathfinding.tilemap.HasTile(cellPosition) == true & Pathfinding.Is_Wall.HasTile(cellPosition) == false & Pathfinding.Is_Obstacle.HasTile(cellPosition) == false & Pathfinding.Is_Enemies.HasTile(cellPosition) == false & cellPosition != Enemy_Idle.m_EnemyCellPosition)
            {
                transform.position = Pathfinding.tilemap.GetCellCenterWorld(cellPosition);

            }
            else
            {
                m_Tolerance = 2f;
            }
        }

        if (m_Magnitud < m_Tolerance)
        {
            m_Tolerance = 0.2f;
            m_fsm.SetState(m_fsm.m_Idle);
        }
                
    }

    public override void OnExit()
    {
        CurrentMovingTime = 0;
    }

}
