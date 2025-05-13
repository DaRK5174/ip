using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    public Transform package; // Пакетик
    public Transform anchor; // Точка крепления

    void Update()
    {
        Vector3 ropeDirection = package.position - anchor.position; 
        Vector3 perpendicular = new Vector3(-ropeDirection.y, ropeDirection.x).normalized;

        Debug.DrawLine(anchor.position, anchor.position + perpendicular, Color.red); 
    }
}
