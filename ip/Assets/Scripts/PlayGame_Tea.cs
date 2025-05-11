using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame_Tea : MonoBehaviour
{
    public Rigidbody2D Player;
    void Start()
    {
    
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.parent = null;
            Player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
