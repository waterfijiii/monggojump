using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderButton : MonoBehaviour
{
    public void LoadSceneOnClick()
    {
        // Load the specified scene
        SceneManager.LoadScene("SampleScene");
    }
}