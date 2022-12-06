using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
 	public GameManager gm;


    [SerializeField]
    public static float playerHealth = 5f;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
        	playerHealth--;
        }

        if (playerHealth == 0) 
        {
        	gm.GameOver();
        }

        if (collision.gameObject.tag == "cookies")
        {
            playerHealth++;
        }
    }
}
