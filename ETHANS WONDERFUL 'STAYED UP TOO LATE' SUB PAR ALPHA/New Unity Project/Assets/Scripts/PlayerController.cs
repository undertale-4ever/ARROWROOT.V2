/* Prototype Player Controller
 * By: Ethan Young
 * Description: Player should be able to jump and duck 
 * Last Updated: 1/30/19
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    bool jumpCheck = true;
    public string NextScene = "GameOver";
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            jumpCheck = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //set rb to be Rigidbody2D
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //Player jumps when Space is pressed
        if (Input.GetKeyDown("space"))
        {
            if (jumpCheck == true)
            {
                float jump = 7f;
                rb.velocity = Vector2.up * jump;
            }
            jumpCheck = false;
        }
        //Player jumps when arrowUp is pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (jumpCheck == true)
            {
                float jump = 7f;
                rb.velocity = Vector2.up * jump;
            }
            jumpCheck = false;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            //change anim state
            myAnim.SetInteger("State", 2);
            Collider2D rbCollider = GetComponent<Collider2D>();  
            rbCollider.transform.position = new Vector2(0f,-4f); 
        }
        else
        {
            myAnim.SetInteger("State", 1);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        SceneManager.LoadScene(NextScene);
    }
}
