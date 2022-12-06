using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpGO : MonoBehaviour
{

    public AudioSource playSound;
    // Start is called before the first frame update
    private void OnTriggerEnter2D( Collider2D collision)
     {

        if ( collision.tag == "Player")
        {
            if (health.playerHealth <= 7)
            {
                health.playerHealth++;
                Destroy(gameObject);
                playSound.Play();
            } else {
                Debug.Log("Health Full!");
            }
            
            //Do something
        }
     }
}
