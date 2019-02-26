using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuNavigation : MonoBehaviour
{
    public Button playBtn;
    public Button settingsBtn;
    public Button creditsBtn;
    public Button backBtn;
    public Button backBtn2;
    public GameObject mainMenu;
    public GameObject settings;
    public GameObject credits;

    // Start is called before the first frame update
    void Start()
    {
        playBtn.onClick.AddListener(PlayGame);
        settingsBtn.onClick.AddListener(OpenSettings);
        creditsBtn.onClick.AddListener(OpenCredits);
        backBtn.onClick.AddListener(BackToMain);
        backBtn2.onClick.AddListener(BackToMain);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void PlayGame()
    {

    }

    void OpenSettings()
    {
        mainMenu.gameObject.SetActive(false);
        settings.gameObject.SetActive(true);
        credits.gameObject.SetActive(false);
    }

    void OpenCredits()
    {
        mainMenu.gameObject.SetActive(false);
        settings.gameObject.SetActive(false);
        credits.gameObject.SetActive(true);
    }

    void BackToMain()
    {
        mainMenu.gameObject.SetActive(true);
        settings.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
    }
}
