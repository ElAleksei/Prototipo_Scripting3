using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Potion", menuName = "Potions")]
public class Potions : ScriptableObject
{
    public int HP;
    public Sprite potionsprite;
}

