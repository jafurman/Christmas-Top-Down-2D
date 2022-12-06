using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timeValue = 160f;
    public Text timeText;
    public GameManager gm;
    public GameObject boss;
    public GameObject bossSpawnMessage;
    public static int counter = 1;
    // Update is called once per frame
    void Update()
    {
    	if (timeValue >= 0)
    	{
    		timeValue -= Time.deltaTime;
    	}
        else
        {
        	timeValue = 0;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
    	if (timeToDisplay < 0 || (Enemy.numOfEnemiesInLevel == 0))
    	{
            if (boss != null && (counter == 1))
            {
                counter++;
                boss.SetActive(true);
                Debug.Log("First");
                StartCoroutine(bossSpawn());
            }
            
            timeToDisplay = 0;
    	}

        IEnumerator bossSpawn()
            {
                Debug.Log("Boss message should spawn");
                bossSpawnMessage.SetActive(true);
                yield return new WaitForSeconds(2f);
                bossSpawnMessage.SetActive(false);
            }

    	float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    	float seconds = Mathf.FloorToInt(timeToDisplay % 60);

    	timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
