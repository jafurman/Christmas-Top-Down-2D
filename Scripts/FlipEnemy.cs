using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipEnemy : MonoBehaviour
{
    public Transform playerCharacter;
  private SpriteRenderer spriteRenderer;
 
  public void Awake()
  {
      this.spriteRenderer = this.GetComponent<SpriteRenderer>();
  }

  
 
 
  public void Update()
  {
      this.spriteRenderer.flipX = playerCharacter.transform.position.x < this.transform.position.x;

         {
if (playerCharacter == null) playerCharacter = GameObject.FindGameObjectWithTag("Player").transform; }

  }
    
    
 
}
