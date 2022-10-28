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
    public static void UIWeapon(GameObject Weapon)
    {
        weapondisplay = Weapon.GetComponent<WeaponDisplay>();
        newsprite = Weapon.GetComponent<SpriteRenderer>();
        image.color = new Color(255, 255, 255, 255);
        image.sprite = newsprite.sprite;
        player.Damage = weapondisplay.damage;
        Debug.Log("A");
    }
}
