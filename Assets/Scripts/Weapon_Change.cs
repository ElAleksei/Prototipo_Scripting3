using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon_Change : MonoBehaviour
{
    public static Image image;
    public static SpriteRenderer newsprite;

    private void Start()
    {
        image = GetComponent<Image>();
    }
    public static void UIWeapon(GameObject Weapon)
    {
        newsprite = Weapon.GetComponent<SpriteRenderer>();
        image.sprite = newsprite.sprite;
        Debug.Log("A");
    }
}
