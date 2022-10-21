using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponDisplay : MonoBehaviour
{
    public SpriteRenderer sprite;

    public static GameObject Ins_Weapon;
    public static GameObject Sword;
    public static GameObject Sword2;
    public static GameObject Bow;
    public static GameObject [] Weapon_List;
    public static int Random_Weapon;

    public Weapons weapon;

    public Vector3Int cell_position;
    public int damage;


    void Start()
    {

        Weapon_List = new GameObject[3];
        Sword = Resources.Load("Sword") as GameObject;
        Sword2 = Resources.Load("Sword2") as GameObject;
        Bow = Resources.Load("Bow") as GameObject;
        Weapon_List[0] = Sword;
        Weapon_List[1] = Sword2;
        Weapon_List[2] = Bow;

        sprite = GetComponent<SpriteRenderer>();

        cell_position = Pathfinding.tilemap.WorldToCell(transform.position);
        damage = weapon.Damage;
        sprite.sprite = weapon.Image;
    }

    public static void CreateWeapon(Vector3 Position)
    {
        Random_Weapon = Random.Range(0,Weapon_List.Length);
        
        Ins_Weapon = Instantiate(Weapon_List[Random_Weapon], null, true);
        Ins_Weapon.transform.position = Position;
    }

}
