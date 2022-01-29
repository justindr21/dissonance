using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;

    public void playGame() {
        SceneManager.LoadScene("GameScene");
    }

    public void back() {
        mainMenu.SetActive(true);
    }
 
    public void exitGame() {
        Application.Quit();
    }
}
