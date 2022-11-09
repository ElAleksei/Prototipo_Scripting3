using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int Max_Health;
    public Slider health_slider;

    public void SetBar(int Health)
    {
        //Se actualiza la barra de vida a la vida del jugador
        health_slider.value = Health;
    }
}
