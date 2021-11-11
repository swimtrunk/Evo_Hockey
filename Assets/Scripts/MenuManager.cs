using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject rulesMenuUI;
    public GameObject castMenuUI;
    public GameObject mainMenuUI;

    public void Quit()
    {
        Debug.Log("Can't believe you just quit air-hockey, you're so bad. Learn to play. Git gud.");
        Application.Quit();
    }

    public void StartGame()
    {
        FindObjectOfType<AudioManager>().Play("Start");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadCastMenu()
    {
        mainMenuUI.SetActive(false);
        castMenuUI.SetActive(true);
    }

    public void LoadRulesMenu()
    {
        mainMenuUI.SetActive(false);
        rulesMenuUI.SetActive(true);
    }

    public void LoadMenu()
    {
        rulesMenuUI.SetActive(false);
        castMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

}
