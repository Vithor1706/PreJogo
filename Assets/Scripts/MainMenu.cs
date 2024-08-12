using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Verifique o nome da cena
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
