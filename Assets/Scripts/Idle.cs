using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Idle : State
{
    public static Vector3Int PlayerCellPosition;
    public static Vector2 Target;
    public static Vector2 InitialPos;
    public static Vector3 m_Attack_Target;
    public static Vector3Int m_Int_Target;
    public static Vector3Int m_V2_Target;

    public float m_Tolerance = 1f;
    public float m_Mag;
    public float m_Distance_From_Enemy;

    public Box [] Box_List;
    public GameObject m_WoodParticles;
    public GameObject m_Instantiate_Wood;
    GameObject BoxAudio;
    AudioSource m_BoxSound;

    public GameObject m_PotionParticles;
    public GameObject m_Instantiate_Potion;

    public GameObject [] Weapon_List;
    public GameObject [] Potion_List;

    /// <summary>
    /// Se otorga la posicion del jugador en tilemap
    /// </summary>
    public override void OnEnter()
    {
        PlayerCellPosition = Pathfinding.tilemap.WorldToCell(transform.position);

        m_WoodParticles = Resources.Load("Wood_Particles") as GameObject;
    }

    public override void OnUpdate()
    {
        BoxAudio = GameObject.Find("BoxSFX");
        m_BoxSound = BoxAudio.GetComponent<AudioSource>();

        Box_List = GameObject.FindObjectsOfType<Box>();

        //Caso del input de movimiento
        if (Input.GetMouseButtonDown(0))
        {
            InitialPos = transform.position;
            Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            m_fsm.SetState(m_fsm.m_Move);
        }
        
        //Caso del input de accion
        if (Input.GetMouseButtonDown(1))
        {
            //se calcula donde se dio click
            m_Attack_Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            m_Int_Target = Pathfinding.Is_Object.WorldToCell(m_Attack_Target);
            m_V2_Target = new Vector3Int(m_Int_Target.x,m_Int_Target.y,0);

            //Magnitud entre la posicion actual del jugador y el punto de click
            m_Mag = (PlayerCellPosition - m_V2_Target).magnitude;
            m_Mag = Mathf.Abs(m_Mag);

            //Se revisa donde estan las cajas de la escena
            for (int i = 0; i < Box_List.Length; i++)
            {
                if (Box_List[i] == null)
                {
                    continue;
                }

                Box Current_Box = Box_List[i];

                //En caso de que el punto de click sea una caja se revisa lo siguiente
                if (m_V2_Target == Current_Box.m_BoxPosition & m_Mag <= m_Tolerance)
                {
                    m_Instantiate_Wood = Instantiate(m_WoodParticles, null, true);
                    m_Instantiate_Wood.transform.position = new Vector3(Current_Box.transform.position.x, Current_Box.transform.position.y, Current_Box.transform.position.z);
                    //Funcion de creacion de armas
                    WeaponDisplay.CreateWeapon(new Vector3(Current_Box.transform.position.x, Current_Box.transform.position.y, Current_Box.transform.position.z));
                    m_BoxSound.Play();
                    Destroy(Current_Box.gameObject);
                }
            }                  

            //Se revisa la distancia con el enemigo
            m_Distance_From_Enemy = (PlayerCellPosition - Enemy_Idle.m_EnemyCellPosition).magnitude;
            m_Distance_From_Enemy = Mathf.Abs(m_Distance_From_Enemy);
            
            //En caso de ataque
            if (m_V2_Target == Enemy_Idle.m_EnemyCellPosition & m_Distance_From_Enemy <= m_Tolerance)
            {
                m_fsm.SetState(m_fsm.m_Attack);
            }

        }

        Weapon_List = GameObject.FindGameObjectsWithTag("Weapon");
        
        //Se revisa la posicion de las armas para saber si el jugador esta sobre ellas
        if (Weapon_List.Length > 0)
        {
            for (int i = 0; i < Weapon_List.Length; i++)
            {
                if (Weapon_List[i] == null)
                {
                    continue;
                }

                GameObject Current_Weapon = Weapon_List[i];
                Vector3Int Current_CellPosition = Pathfinding.tilemap.WorldToCell(Current_Weapon.transform.position);

                //Caso de estar sobre arma
                if (PlayerCellPosition == Current_CellPosition)
                {
                    //Funcion de cambio de arma
                    Weapon_Change.UIWeapon(Current_Weapon);
                    Destroy(Current_Weapon.gameObject);
                }
            }
        }

        Potion_List = GameObject.FindGameObjectsWithTag("Potion");

        //Se revisa la posicion de las armas
        if (Potion_List.Length > 0)
        {
            for (int i = 0; i < Potion_List.Length; i++)
            {
                if (Potion_List[i] == null)
                {
                    continue;
                }

                GameObject Current_Potion = Potion_List[i];
                Vector3Int Current_PotionPosition = Pathfinding.tilemap.WorldToCell(Current_Potion.transform.position);
                
                //Caso de estar sobre una pocion
                if (PlayerCellPosition == Current_PotionPosition)
                {
                    //Funcion de obtencion de pocion
                    PotionsDisplay.DrawPotion(Current_Potion);
                    Destroy(Current_Potion.gameObject);
                }
            }
        }
    }

    public override void OnExit()
    {

    }

}
