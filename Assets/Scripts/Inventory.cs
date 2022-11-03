using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Image PotionSprite = PotionsDisplay.Inventory[0].GetComponent<Image>();

            if (PotionSprite != null)
            {
                string Name = PotionSprite.sprite.name;
                if (Name == "Potion")
                {
                    player.Life += 3;
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                }
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
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                }
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
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                }
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
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                }
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
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                }
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
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                }
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
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                }
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
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                }
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
                }

                if (Name == "Potion2")
                {
                    player.Life += 5;
                }
            }

            PotionSprite.sprite = null;
        }
    }
}
