using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class presentManager : MonoBehaviour
{
	public GameObject victoryScreen;
	public Text presents;
	public static int NumOfPresents = 11;

    // Update is called once per frame
    void Update()
    {
   
        presents.text = NumOfPresents.ToString() + " Presents Left";
        if (NumOfPresents <= 0 )
        {
        	victoryScreen.SetActive(true);
        }
    }
}
