using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public Animator chestAnimator;

    void Start()
    {
        chestAnimator.SetBool("isOpen", false);
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        Player player = collider.GetComponent<Player>();

        if (player.dropItem)
        {
            chestAnimator.SetBool("isOpen", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        Player player = collider.GetComponent<Player>();

        chestAnimator.SetBool("isOpen", false);
        player.dropItem = false;
    }
}
