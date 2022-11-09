using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponDisplay : MonoBehaviour
{

    public static GameObject Ins_Weapon;
    public static GameObject Sword;
    public static GameObject Sword2;
    public static GameObject Bow;
    public static GameObject [] Weapon_List;
    public static int Random_Weapon;

    public Weapons SwordWeapon;
    public WeaponDisplay SwordDisplay;

    public Weapons Sword2Weapon;
    public WeaponDisplay Sword2Display;

    public Weapons BowWeapon;
    public WeaponDisplay BowDisplay;
    public SpriteRenderer BowSprite;

    public Vector3Int cell_position;
    public int damage;


    void Start()
    {

        Weapon_List = new GameObject[3];
        Sword = Resources.Load("SwordPrefab") as GameObject;
        Sword2 = Resources.Load("Sword2Prefab") as GameObject;
        Bow = Resources.Load("BowPrefab") as GameObject;
        Weapon_List[0] = Sword;
        Weapon_List[1] = Sword2;
        Weapon_List[2] = Bow;


        cell_position = Pathfinding.tilemap.WorldToCell(transform.position);

        SwordWeapon = Resources.Load("Sword") as Weapons;
        SwordDisplay = Sword.GetComponent<WeaponDisplay>();
        SwordDisplay.damage = SwordWeapon.Damage;

        Sword2Weapon = Resources.Load("Sword2") as Weapons;
        Sword2Display = Sword2.GetComponent<WeaponDisplay>();
        Sword2Display.damage = Sword2Weapon.Damage;

        BowWeapon = Resources.Load("Bow") as Weapons;
        BowDisplay = Bow.GetComponent<WeaponDisplay>();
        BowDisplay.damage = BowWeapon.Damage;
    }

    /// <summary>
    /// Se crea un arma random al destruir una caja
    /// </summary>
    /// <param name="Position"></param> Posicion actual del jugador
    public static void CreateWeapon(Vector3 Position)
    {
        Random_Weapon = Random.Range(0,Weapon_List.Length);
        Ins_Weapon = Instantiate(Weapon_List[Random_Weapon], null, true);
        Ins_Weapon.transform.position = Position;
    }

}
