using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: Characters
{
    public Player m_player;


    [SerializeField]
    private int m_Energy;

    public bool m_HasWeapon;

    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        m_player = GetComponent<Player>();
        m_player.Life = 10;
        m_player.Damage = 1;    
    }
    void Update()
    {
        healthbar.SetBar(m_player.Life);

        if (m_player.Life <= 0)
        {
            Destroy(gameObject);
            Application.Quit();
        }

    }
}
