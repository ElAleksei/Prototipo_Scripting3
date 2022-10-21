using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Pathfinding
{
    public static Tilemap tilemap;
    public static Tilemap Is_Wall;
    public static Tilemap Is_Obstacle;
    public static Tilemap Is_Object;
    public static Tilemap Is_Enemies;
    public void Awake()
    {

    }

    public static void Initialize()
    {
        tilemap = GameObject.Find("Floor").GetComponent<Tilemap>();
        Is_Wall = GameObject.Find("Wall").GetComponent<Tilemap>();
        Is_Obstacle = GameObject.Find("Obstacles").GetComponent<Tilemap>();
        Is_Object = GameObject.Find("Breakable Obj").GetComponent<Tilemap>();
        Is_Enemies = GameObject.Find("Enemies").GetComponent<Tilemap>();
    }

}
