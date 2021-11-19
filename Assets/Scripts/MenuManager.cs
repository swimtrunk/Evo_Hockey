using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject rulesMenuUI;
    public GameObject castMenuUI;
    public GameObject mainMenuUI;

    public void Quit()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
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
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        mainMenuUI.SetActive(false);
        castMenuUI.SetActive(true);
    }

    public void LoadRulesMenu()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        mainMenuUI.SetActive(false);
        rulesMenuUI.SetActive(true);
    }

    public void LoadMenu()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        rulesMenuUI.SetActive(false);
        castMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

}
