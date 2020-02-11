/*
 * move.cs
 * By:Esther Strathy
 * 2/10/2020
 * Description: side scroller for objects
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    public Vector2 velocity = new Vector2(0f, 0f);

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity; 
    }
}