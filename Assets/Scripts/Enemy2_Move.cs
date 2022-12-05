using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2_Move : State
{
    public Enemy2 Enemy2;
    public int RandomNumber;
    public Vector2 LastPos;
    public Vector3 NextPos;
    public Vector3Int PrevPos;
    public override void OnEnter()
    {
        Enemy2 = GameObject.Find("Enemy2").GetComponent<Enemy2>();
        RandomNumber = Random.Range(1, 4);


        //Izquierda arriba
        if (RandomNumber == 1)
        {
            LastPos = new Vector3(transform.position.x + 0.5f, transform.position.y - 0.25f);
            NextPos = new Vector3(transform.position.x - 0.5f, transform.position.y + 0.25f);
            PrevPos = Pathfinding.tilemap.WorldToCell(NextPos);

            if (Pathfinding.tilemap.HasTile(PrevPos) == true & Pathfinding.Is_Wall.HasTile(PrevPos) == false & Pathfinding.Is_Obstacle.HasTile(PrevPos) == false & PrevPos != Idle.PlayerCellPosition)
            {
                Enemy2.UpdateEnemySprite(LastPos, transform.position);
                transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y + 0.25f);
            }
        }

        //Derecha arriba
        if (RandomNumber == 2)
        {
            LastPos = new Vector3(transform.position.x - 0.5f, transform.position.y - 0.25f);
            NextPos = new Vector3(transform.position.x + 0.5f, transform.position.y + 0.25f);
            PrevPos = Pathfinding.tilemap.WorldToCell(NextPos);

            if (Pathfinding.tilemap.HasTile(PrevPos) == true & Pathfinding.Is_Wall.HasTile(PrevPos) == false & Pathfinding.Is_Obstacle.HasTile(PrevPos) == false & PrevPos != Idle.PlayerCellPosition)
            {
                Enemy2.UpdateEnemySprite(LastPos, transform.position);
                transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y + 0.25f);
            }            
        }

        //Izquierda abajo
        if (RandomNumber == 3)
        {
            LastPos = new Vector3(transform.position.x + 0.5f, transform.position.y + 0.25f);
            NextPos = new Vector3(transform.position.x - 0.5f, transform.position.y - 0.25f);
            PrevPos = Pathfinding.tilemap.WorldToCell(NextPos);

            if (Pathfinding.tilemap.HasTile(PrevPos) == true & Pathfinding.Is_Wall.HasTile(PrevPos) == false & Pathfinding.Is_Obstacle.HasTile(PrevPos) == false & PrevPos != Idle.PlayerCellPosition)
            {
                Enemy2.UpdateEnemySprite(LastPos, transform.position);
                transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y - 0.25f);
            }           
        }

        //Derecha abajo
        if (RandomNumber == 4)
        {
            LastPos = new Vector3(transform.position.x - 0.5f, transform.position.y + 0.25f);
            NextPos = new Vector3(transform.position.x + 0.5f, transform.position.y - 0.25f);
            PrevPos = Pathfinding.tilemap.WorldToCell(NextPos);

            if (Pathfinding.tilemap.HasTile(PrevPos) == true & Pathfinding.Is_Wall.HasTile(PrevPos) == false & Pathfinding.Is_Obstacle.HasTile(PrevPos) == false & PrevPos != Idle.PlayerCellPosition)
            {
                Enemy2.UpdateEnemySprite(LastPos, transform.position);
                transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y - 0.25f);
            }           
        }
    }
    public override void OnUpdate()
    {
        m_Enemy2FSM.SetState(m_Enemy2FSM.m_Enemy2_Idle);
    }
    public override void OnExit()
    {

    }
}
