using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject[] Enemy_List;
    public static GameObject Slash;
    public static Image SlashImage;

    private void Start()
    {
        Slash = GameObject.Find("Slash");
        SlashImage = Slash.GetComponent<Image>();
        SlashImage.enabled = false;
    }

    void Update()
    {
        Enemy_List = GameObject.FindGameObjectsWithTag("Enemy");   
        
        if (Enemy_List.Length <= 0)
        {
            Application.Quit();
        }
    }
}
