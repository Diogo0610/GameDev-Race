using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;
public class MenuManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private Text connectButtonText;
    [SerializeField] private InputField usernameInputField;
    [SerializeField] private GameObject menu, introduction, username, howToPlay, options;

    void Start()
    {
        menu.SetActive(true);
        introduction.SetActive(false);
        username.SetActive(false);
        howToPlay.SetActive(false);
        options.SetActive(false);
    }
    public void OnClickPlay()
    {
        menu.SetActive(false);
        introduction.SetActive(true);
    }
    public void OnClickContinue()
    {
        introduction.SetActive(false);
        username.SetActive(true);
    }
    public void OnClickConnect()
    {
        if (usernameInputField.text.Length >= 1)
        {
            PhotonNetwork.NickName = usernameInputField.text;
            connectButtonText.text = Lean.Localization.LeanLocalization.GetTranslationText("Conectando");
            PhotonNetwork.AutomaticallySyncScene = true;
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public void OnClickHowToPlay()
    {
        menu.SetActive(false);
        howToPlay.SetActive(true);
    }
    public void OnClickOptions()
    {
        menu.SetActive(false);
        options.SetActive(true);
    }
    public void OnClickBack()
    {
        username.SetActive(false);
        introduction.SetActive(true);
    }
    public void OnClickBack2()
    {
        introduction.SetActive(false);
        menu.SetActive(true);
    }
    public void OnClickBack3()
    {
        options.SetActive(false);
        menu.SetActive(true);
    }
    public void OnClickVoltar()
    {
        howToPlay.SetActive(false);
        menu.SetActive(true);
    }
    public void OnClickExit()
    {
        Application.Quit();
    }
    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Lobby");
    }
    public void OnClickLanguageButton()
    {
        SceneManager.LoadScene("LanguageSelect");
    }
    public void OnClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
