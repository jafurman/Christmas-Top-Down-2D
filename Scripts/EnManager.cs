using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnManager : MonoBehaviour
{

	public Text enemies;

    // Update is called once per frame
    void Update()
    {
    	int enemyCount = Enemy.numOfEnemiesInLevel;
        enemies.text = enemyCount.ToString() + " Enemies Left";
    }
}
