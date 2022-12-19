using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestApples : MonoBehaviour
{
    [Header("Itens")]
    public GameObject apple;

    bool hasApple = false;

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.GetComponent<Player>())
        {
            Player player = collider.GetComponent<Player>();
            Debug.Log("Player encostou");

            if (player.dropItem)
            {
                Debug.Log("dropItem");

                GameObject Apple =
                    Instantiate(apple,
                    new Vector3(-1.272f, 1.916f, 0),
                    Quaternion.identity,
                    null);
                player.dropItem = false;
            }
        }
    }
}
