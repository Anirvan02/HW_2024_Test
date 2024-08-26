using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
