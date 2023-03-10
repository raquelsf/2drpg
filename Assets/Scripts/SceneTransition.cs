using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;

    public GameObject sceneText;

    public Vector2 playerPosition;

    public VectorValue playerStorage;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Player>())
        {
            Player player = collider.GetComponent<Player>();

            playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene (sceneToLoad);
        }
    }

    private IEnumerator showSceneText()
    {
        sceneText.SetActive(true);
        yield return new WaitForSeconds(4f);
        sceneText.SetActive(false);
    }
}
