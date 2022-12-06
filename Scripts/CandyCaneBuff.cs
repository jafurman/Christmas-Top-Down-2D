using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCaneBuff : MonoBehaviour
{
    public AudioSource playSound;

    public static bool isEaten = false;
    // Start is called before the first frame update
    private void OnTriggerEnter2D( Collider2D collision)
     {

        if ( collision.tag == "Player")
        {
           
                
                isEaten = true;
                Destroy(gameObject);
                playSound.Play();
            
                Debug.Log("Health Full!");
        

            
            //Do something
        }
     }
}
