using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    private Rigidbody2D Player;
    private void GetMouseButtonDown()
    {
        Player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }

}
