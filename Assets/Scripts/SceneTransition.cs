using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;

    public Vector2 playerPosition;

    public VectorValue playerStorage;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Player>())
        {
            playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene (sceneToLoad);
        }
    }
}
