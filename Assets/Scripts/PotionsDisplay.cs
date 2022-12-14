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

    public static GameObject [] Inventory = new GameObject[9];
    public static Image CubeImage;

    public int HP;

    GameObject BagAudio;
    public static AudioSource m_BagSound;

    void Start()
    {
        BagAudio = GameObject.Find("BagSFX");
        m_BagSound = BagAudio.GetComponent<AudioSource>();

        //Creacion de lista de pociones
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

        //Referencia del inventario

        Inventory[0] = GameObject.Find("1");
        Inventory[1] = GameObject.Find("2");
        Inventory[2] = GameObject.Find("3");
        Inventory[3] = GameObject.Find("4");
        Inventory[4] = GameObject.Find("5");
        Inventory[5] = GameObject.Find("6");
        Inventory[6] = GameObject.Find("7");
        Inventory[7] = GameObject.Find("8");
        Inventory[8] = GameObject.Find("9");

    }

    /// <summary>
    /// Con lista de pociones se crea una pocion random y se intancia en la posicion del jugador
    /// </summary>
    /// <param name="Position"></param> Posicion actual del jugador
    public static void CreatePotion(Vector3Int Position)
    {
        RandomPotion = Random.Range(0, Potion_List.Length);
        InsPotion = Instantiate(Potion_List[RandomPotion], null, true);
        Vector3 WorldPosition = Pathfinding.tilemap.CellToLocal(Position);
        InsPotion.transform.position = WorldPosition;
    }

    /// <summary>
    /// Se dibuja el sprite de la pocion en el inventario, siempre en la casilla mas a la inzquierda siempre y cuando este desocupada
    /// </summary>
    /// <param name="Potion"></param> Gameobject sobre el que estuvo el jugador
    public static void DrawPotion(GameObject Potion)
    {       
        SpriteRenderer sprite = Potion.GetComponent<SpriteRenderer>();

        for (int i = 0; i < Inventory.Length; i++)
        {
            Image BoxImage = Inventory[i].GetComponent<Image>();

            if (BoxImage.sprite == null)
            {
                m_BagSound.Play();
                BoxImage.color = new Color(255, 255, 255, 255);
                BoxImage.sprite = sprite.sprite;
                break;
            }
        }      
    }

    public static void UsePotion(GameObject Potion, Input key)
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
