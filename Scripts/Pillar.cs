using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public GameObject pillar;

    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
        	
            //Toggle the Collider on and off when pressing the space bar
             pillar.GetComponent<Collider2D>().enabled = false;

        }
    }
}
