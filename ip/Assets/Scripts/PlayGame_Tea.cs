using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class PlayGame_Tea : SettingPad
{
    public Rigidbody2D rb;
    public Transform mCrep;
    public Transform package;
    public float fors = 2f;

    void Update()
    {

        Vector3 ropeDirection = package.position - mCrep.position;
        Vector3 perpendicular = new Vector3(-ropeDirection.y, ropeDirection.x).normalized;

        Debug.DrawLine(mCrep.position, mCrep.position + perpendicular, Color.red);
        if (Input.GetMouseButton(0))
        {
        
            rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            transform.parent = null;
            rb.AddForce(perpendicular * Mathf.Sin(Time.time) * fors);

            //cxqaB  rb.velocity *= fors;
        }
    }
}
