using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presentUncover : MonoBehaviour
{
    public AudioSource playSound;
    // Start is called before the first frame update
    private void OnTriggerEnter2D( Collider2D collision)
     {

        if ( collision.tag == "Player")
        {
           		presentManager.NumOfPresents--;
                Destroy(gameObject);
                playSound.Play();
   
                Debug.Log("Health Full!");
            
            //Do something
        }
     }
}
