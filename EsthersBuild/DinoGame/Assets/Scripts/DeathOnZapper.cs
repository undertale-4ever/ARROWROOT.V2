/*
 * DeathOnZapper.cs
 * By: Esther Strathy
 * 2/10/2020
 * Description: destroys object on trigger
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnZapper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Zapper")
        {
            Destroy(gameObject);
        }
    }
}
