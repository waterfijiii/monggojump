using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player")) // You can change "Player" to your desired tag
        {

            SceneManager.LoadScene("Menu");
        }
    }
}