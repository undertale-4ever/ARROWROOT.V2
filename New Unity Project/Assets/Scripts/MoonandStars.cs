/********
 * MoonandStars.cs
 * By: Esther Strathy
 * 2/6/2020
 * Description: moves moon and stars and ensures there is only 1 of them 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonandStars : MonoBehaviour
{
    Rigidbody2D moonstarRB;
    public float velocity = -0.5f;
    int objcount; 
    // Start is called before the first frame update
    void Start()
    {
        moonstarRB = FindObjectOfType<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool starmooncount()
    {
        objcount = GameObject.FindObjectsOfType<MoonandStars>().Length;
        if (objcount > 1)
            return false;
        else
            return true;
    }
}
