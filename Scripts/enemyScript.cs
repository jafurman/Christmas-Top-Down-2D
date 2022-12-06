using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    // place this script on any enemy.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        enemySpawnsScript.currEnemies--;
        // might ass something here to update a score counter on the player.
        // might need to add a collision exception to bprders.
    }
}
