using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public Button playBtn;
    public Button settingsBtn;
    public Button creditsBtn;
    public Button backBtn;
    public Button backBtn2;
    public Button aboutBtn;
    public Button backBtn3;
    public GameObject mainMenu;
    public GameObject about;
    public GameObject settings;
    public GameObject credits;


    // Start is called before the first frame update
    void Start()
    {
        playBtn.onClick.AddListener(PlayGame);
        settingsBtn.onClick.AddListener(OpenSettings);
        creditsBtn.onClick.AddListener(OpenCredits);
        aboutBtn.onClick.AddListener(OpenAbout);
        backBtn.onClick.AddListener(BackToMain);
        backBtn2.onClick.AddListener(BackToMain);
        backBtn3.onClick.AddListener(BackToMain);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    void OpenAbout()
    {
        mainMenu.gameObject.SetActive(false);
        about.gameObject.SetActive(true);
        settings.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
    }

    void OpenSettings()
    {
        mainMenu.gameObject.SetActive(false);
        about.gameObject.SetActive(false);
        settings.gameObject.SetActive(true);
        credits.gameObject.SetActive(false);
    }

    void OpenCredits()
    {
        mainMenu.gameObject.SetActive(false);
        about.gameObject.SetActive(false);
        settings.gameObject.SetActive(false);
        credits.gameObject.SetActive(true);
    }

    void BackToMain()
    {
        mainMenu.gameObject.SetActive(true);
        settings.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        about.gameObject.SetActive(false);
    }
}
