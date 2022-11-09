using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Vector3Int m_BoxPosition;
    /// <summary>
    /// Se asigna una posición a los objetos de clase caja
    /// </summary>
    void Start()
    {
        m_BoxPosition = Pathfinding.tilemap.WorldToCell(gameObject.transform.position);
    }

    void Update()
    {

    }

}
