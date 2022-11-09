using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon_Change : MonoBehaviour
{
    public static Image image;
    public static SpriteRenderer newsprite;
    public static Player player;
    public static WeaponDisplay weapondisplay;

    private void Start()
    {
        image = GetComponent<Image>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    /// <summary>
    /// Se cambia el sprite del canvas por la del arma que se recogio
    /// </summary>
    /// <param name="Weapon"></param> Arma sobre la que estuvo el jugador
    public static void UIWeapon(GameObject Weapon)
    {
        weapondisplay = Weapon.GetComponent<WeaponDisplay>();
        newsprite = Weapon.GetComponent<SpriteRenderer>();
        image.color = new Color(255, 255, 255, 255);
        PotionsDisplay.m_BagSound.Play();
        image.sprite = newsprite.sprite;
        player.Damage = weapondisplay.damage;        
    }
}
