using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] Enemy_List;

    // Update is called once per frame
    void Update()
    {
        Enemy_List = GameObject.FindGameObjectsWithTag("Enemy");   
        
        if (Enemy_List.Length <= 0)
        {
            Application.Quit();
        }
    }
}
