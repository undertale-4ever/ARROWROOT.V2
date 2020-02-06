/****
 * cloudsSideScroll.cs
 * By: Esther Strathy
 * 2/5/2020
 * Description: Moves clouds to side, destroys clouds, spawns clouds
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudsSideScroll : MonoBehaviour
{
    Rigidbody2D cloudRB;
    public GameObject cloud; 
    public float cloudspeed = -0.5f;
    public float minDelay, maxDelay, spawnY;
    Vector2 spawnpos;
    float cloudnum;
    
    // Start is called before the first frame update
    void Start()
    {
        //gets rigidbody component 
        cloudRB = FindObjectOfType<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        cloudmove();
        
    }

    void cloudmove()
    {
        //applies velocity to clouds
        cloudRB.velocity = new Vector2 (cloudspeed,0f); 
    }

    IEnumerator cloudspawn()
    {
        //waits a random amount of time
        yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        //gets random y position 
        Vector2 position = new Vector2(10f, Random.Range(0f, 5f)); 
        if (cloudcount() == true)
        {
            GameObject eClone = Instantiate(cloud, position , Quaternion.identity);
        }
    }
    //checks number of clouds 
    bool cloudcount()
    {
        cloudnum = GameObject.FindObjectsOfType<cloudsSideScroll>().Length;
        if (cloudnum > 5)
            return false;
        else
            return true; 
    }
    //destroys clouds
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject); 
    }
}
