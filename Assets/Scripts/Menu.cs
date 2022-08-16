using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject instructionsMenu;
    public GameObject lobbyMenu;
    public GameObject joinMenu;
    public GameObject inLobbyMenu;
    public GameObject hostMenu;

    public InputField hostNicknameInput;
    public InputField clientNicknameInput;
    public InputField IPAddress;

    public Text player1Name;
    public Text player2Name;

    void Start()
    {
        mainMenu.SetActive(true);
        instructionsMenu.SetActive(false);
        lobbyMenu.SetActive(false);
        joinMenu.SetActive(false);
        inLobbyMenu.SetActive(false);
    }

    public void SwitchToMainMenu()
    {
        mainMenu.SetActive(true);
        instructionsMenu.SetActive(false);
        inLobbyMenu.SetActive(false);
        lobbyMenu.SetActive(false);

        player1Name.text = "";
        player2Name.text = "";
    }

    public void SwitchToInstructionsMenu()
    {
        mainMenu.SetActive(false);
        instructionsMenu.SetActive(true);
    }

    public void SwitchToLobbyMenu()
    {
        mainMenu.SetActive(false);
        joinMenu.SetActive(false);
        hostMenu.SetActive(false);
        lobbyMenu.SetActive(true);
    }

    public void SwtichToJoinMenu()
    {
        lobbyMenu.SetActive(false);
        inLobbyMenu.SetActive(false);
        joinMenu.SetActive(true);

        player1Name.text = "";
        player2Name.text = "";
    }

    public void SwitchToInLobby()
    {
        joinMenu.SetActive(false);
        hostMenu.SetActive(false);
        inLobbyMenu.SetActive(true);
    }

    public void SwitchToHostMenu()
    {
        lobbyMenu.SetActive(false);
        hostMenu.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("H004_scene");
    }

    public void StartMultiplayerGame()
    {

    }

    public void SetHostNickname()
    {
        player1Name.text = hostNicknameInput.text.ToString();
        hostNicknameInput.text = "";
    }

    public void SetClientNickname()
    {
        player2Name.text = clientNicknameInput.text.ToString();
        clientNicknameInput.text = "";
    }

    public void SetIPAddress()
    {
        //pass in ip
        IPAddress.text = "";
    }
}
