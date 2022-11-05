using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    Player player;
    GameObject m_Instantiate_Potion;
    GameObject m_PotionParticles;

    GameObject PotionAudio;
    AudioSource m_PotionSound;
    void Start()
    {
        player = FindObjectOfType<Player>();
        m_PotionParticles = Resources.Load("Potion_Particles") as GameObject;

        PotionAudio = GameObject.Find("PotionSFX");
        m_PotionSound = PotionAudio.GetComponent<AudioSource>();
    }

    void Update()
    {
        player = FindObjectOfType<Player>();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Image PotionSprite = PotionsDisplay.Inventory[0].GetComponent<Image>();

            if (PotionSprite != null)
            {
                string Name = PotionSprite.sprite.name;
                if (Name == "Potion")
                {
                    player.Life += 3;
                    m_PotionSound.Play();
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                    m_PotionSound.Play();
                }

                m_Instantiate_Potion = Instantiate(m_PotionParticles, null, true);
                m_Instantiate_Potion.transform.position = player.transform.position;
            }

            PotionSprite.sprite = null;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Image PotionSprite = PotionsDisplay.Inventory[1].GetComponent<Image>();

            if (PotionSprite != null)
            {
                string Name = PotionSprite.sprite.name;
                if (Name == "Potion")
                {
                    player.Life += 3;
                    m_PotionSound.Play();
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                    m_PotionSound.Play();
                }

                m_Instantiate_Potion = Instantiate(m_PotionParticles, null, true);
                m_Instantiate_Potion.transform.position = player.transform.position;
            }

            PotionSprite.sprite = null;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Image PotionSprite = PotionsDisplay.Inventory[2].GetComponent<Image>();

            if (PotionSprite != null)
            {
                string Name = PotionSprite.sprite.name;
                if (Name == "Potion")
                {
                    player.Life += 3;
                    m_PotionSound.Play();
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                    m_PotionSound.Play();
                }

                m_Instantiate_Potion = Instantiate(m_PotionParticles, null, true);
                m_Instantiate_Potion.transform.position = player.transform.position;
            }

            PotionSprite.sprite = null;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Image PotionSprite = PotionsDisplay.Inventory[3].GetComponent<Image>();

            if (PotionSprite != null)
            {
                string Name = PotionSprite.sprite.name;
                if (Name == "Potion")
                {
                    player.Life += 3;
                    m_PotionSound.Play();
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                    m_PotionSound.Play();
                }

                m_Instantiate_Potion = Instantiate(m_PotionParticles, null, true);
                m_Instantiate_Potion.transform.position = player.transform.position;
            }

            PotionSprite.sprite = null;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Image PotionSprite = PotionsDisplay.Inventory[4].GetComponent<Image>();

            if (PotionSprite != null)
            {
                string Name = PotionSprite.sprite.name;
                if (Name == "Potion")
                {
                    player.Life += 3;
                    m_PotionSound.Play();
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                    m_PotionSound.Play();
                }

                m_Instantiate_Potion = Instantiate(m_PotionParticles, null, true);
                m_Instantiate_Potion.transform.position = player.transform.position;
            }

            PotionSprite.sprite = null;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Image PotionSprite = PotionsDisplay.Inventory[5].GetComponent<Image>();

            if (PotionSprite != null)
            {
                string Name = PotionSprite.sprite.name;
                if (Name == "Potion")
                {
                    player.Life += 3;
                    m_PotionSound.Play();
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                    m_PotionSound.Play();
                }

                m_Instantiate_Potion = Instantiate(m_PotionParticles, null, true);
                m_Instantiate_Potion.transform.position = player.transform.position;
            }

            PotionSprite.sprite = null;
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Image PotionSprite = PotionsDisplay.Inventory[6].GetComponent<Image>();

            if (PotionSprite != null)
            {
                string Name = PotionSprite.sprite.name;
                if (Name == "Potion")
                {
                    player.Life += 3;
                    m_PotionSound.Play();
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                    m_PotionSound.Play();
                }

                m_Instantiate_Potion = Instantiate(m_PotionParticles, null, true);
                m_Instantiate_Potion.transform.position = player.transform.position;
            }

            PotionSprite.sprite = null;
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Image PotionSprite = PotionsDisplay.Inventory[7].GetComponent<Image>();

            if (PotionSprite != null)
            {
                string Name = PotionSprite.sprite.name;
                if (Name == "Potion")
                {
                    player.Life += 3;
                    m_PotionSound.Play();
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                    m_PotionSound.Play();
                }

                m_Instantiate_Potion = Instantiate(m_PotionParticles, null, true);
                m_Instantiate_Potion.transform.position = player.transform.position;
            }

            PotionSprite.sprite = null;
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Image PotionSprite = PotionsDisplay.Inventory[8].GetComponent<Image>();

            if (PotionSprite != null)
            {
                string Name = PotionSprite.sprite.name;
                if (Name == "Potion")
                {
                    player.Life += 3;
                    m_PotionSound.Play();
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                    m_PotionSound.Play();
                }

                m_Instantiate_Potion = Instantiate(m_PotionParticles, null, true);
                m_Instantiate_Potion.transform.position = player.transform.position;
            }

            PotionSprite.sprite = null;
        }
    }
}
