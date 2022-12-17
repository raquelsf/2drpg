using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apples : MonoBehaviour
{
   public AudioClip dropAppleSound;

   private void OnTriggerEnter2D(Collider2D collider)
   {
        if(collider.GetComponent<Player>())
        {
            Player player = collider.GetComponent<Player>();

            player.entity.entityAudio.PlayOneShot(dropAppleSound);
            player.numOfApples++;

            Destroy(this.gameObject);
        }
   }
}
