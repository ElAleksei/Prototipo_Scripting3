using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionsDisplay : MonoBehaviour
{
    public static GameObject[] Potion_List;
    public GameObject Potion;
    public GameObject Potion_2;
    public static GameObject InsPotion;

    public static int RandomPotion;

    public Potions Potion1;
    public PotionsDisplay Potion1Display;
    public SpriteRenderer Potion1Sprite;

    public Potions Potion2;
    public PotionsDisplay Potion2Display;
    public SpriteRenderer Potion2Sprite;

    public GameObject m_PotionParticles;

    public int HP;


    void Start()
    {

        Potion_List = new GameObject[2];
        Potion = Resources.Load("Potion1Prefab") as GameObject;
        Potion_2 = Resources.Load("Potion2Prefab") as GameObject;
        Potion_List[0] = Potion;
        Potion_List[1] = Potion_2;

        Potion1 = Resources.Load("ScriptPotion") as Potions;
        Potion1Display = Potion.GetComponent<PotionsDisplay>();
        Potion1Display.HP = Potion1.HP;

        Potion2 = Resources.Load("ScriptPotion2") as Potions;
        Potion2Display = Potion.GetComponent<PotionsDisplay>();
        Potion2Display.HP = Potion2.HP;
    }

    public static void CreatePotion(Vector3Int Position)
    {
        RandomPotion = Random.Range(0, Potion_List.Length);
        InsPotion = Instantiate(Potion_List[RandomPotion], null, true);
        Vector3 WorldPosition = Pathfinding.tilemap.CellToLocal(Position);
        InsPotion.transform.position = WorldPosition;
    }

    public static void UsePotion(GameObject Potion)
    {
        PotionsDisplay Display = Potion.GetComponent<PotionsDisplay>();
        Player player = FindObjectOfType<Player>();
        if (player.Life + Display.HP > 10)
        {
            player.Life = 10;
        }

        else
        {
            player.Life += Display.HP;
        }

        

    }
}
