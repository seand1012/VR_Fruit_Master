using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStartMenu : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject mainMenu;
    public GameObject weaponsMenu;
    public GameObject sceneryMenu;
    public GameObject rangeMenu;
    public GameObject aboutMenu;
    public GameObject descriptionPanel;

    [Header("Main Menu Buttons")]
    public Button startButton;
    public Button weaponsButton;
    public Button sceneryButton;
    public Button rangeButton;
    public Button aboutButton;
    public Button quitButton;

    public List<Button> returnButtons;

    void Start()
    {
        EnableMainMenu();

        startButton.onClick.AddListener(StartGame);
        weaponsButton.onClick.AddListener(EnableWeaponsMenu);
        sceneryButton.onClick.AddListener(EnableSceneryMenu);
        rangeButton.onClick.AddListener(EnableRangeMenu);
        aboutButton.onClick.AddListener(EnableAboutMenu);
        quitButton.onClick.AddListener(QuitGame);

      
    }

    public void StartGame()
    {
        HideAll();
        SceneManager.LoadScene("newRoom");
        Debug.Log("Starting the game...");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting the game...");
    }

    public void HideAll()
    {
        mainMenu.SetActive(false);
        weaponsMenu.SetActive(false);
        sceneryMenu.SetActive(false);
        rangeMenu.SetActive(false);
        aboutMenu.SetActive(false);
        descriptionPanel.SetActive(false);
    }

    public void EnableMainMenu()
    {
        HideAll();
        mainMenu.SetActive(true);
    }
   /** public void OpenWeaponSelectionScene()
    { 
    }**/


    public void EnableWeaponsMenu()
    {
        HideAll();
        weaponsMenu.SetActive(true);
    }

    public void EnableSceneryMenu()
    {
        HideAll();
        sceneryMenu.SetActive(true);
    }

    public void EnableRangeMenu()
    {
        HideAll();
        rangeMenu.SetActive(true);
    }

    public Text descriptionText; // Reference to the Text component of the description panel

    public void EnableAboutMenu()
    {
        HideAll();
        aboutMenu.SetActive(true);
    }
}