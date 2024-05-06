using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartMainGame()
    {
        Debug.Log("Game started");
        SceneManager.LoadScene("SampleScene");
    }
}
