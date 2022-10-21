using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Aprox_Function
{
    public static float m_Tolerance;
    public static float m_Answer;

    public static void Aprox(float A, float B)
    {
        m_Answer = Mathf.Abs(A - B);
    }
}
