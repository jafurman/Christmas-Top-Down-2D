using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easterEgg : MonoBehaviour
{
    public AudioSource playSound;
    public GameObject message;
    public static bool isEaten = false;
    // Start is called before the first frame update
    private void OnTriggerEnter2D( Collider2D collision)
     {

        if ( collision.tag == "Player")
        {
           
                
                isEaten = true;
                Destroy(gameObject);
                playSound.Play();
                StartCoroutine(bossSpawn());
            
        

            
            //Do something
        }

        IEnumerator bossSpawn()
           {
                Debug.Log("Boss message should spawn");
                message.SetActive(true);
                PlayerMovement.moveSpeed = 7f;
                projectileWeaponScript.fireForce = 25f;
                yield return new WaitForSeconds(30f);
                projectileWeaponScript.fireForce = 12f;
                PlayerMovement.moveSpeed = 5f;
                message.SetActive(false);
            }
     }
}

    
           
     
