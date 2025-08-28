using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadSceneAsync("Assets/Scenes/storeFront.unity", LoadSceneMode.Single);
    }
}
