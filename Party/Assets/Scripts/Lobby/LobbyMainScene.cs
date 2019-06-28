using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LobbyMainScene : MonoBehaviour
{
    [Header("Login Panel")]
    public GameObject loginPanel;

    public TMP_InputField playerNameInput;

    [Header("Selection Panel")]
    public GameObject selectionPanel;

    [Header("Create Room Panel")]
    public GameObject createRoomPanel;

    public TMP_InputField roomNameInputField;

    [Header("Join Random Room Panel")]
    public GameObject joinRandomRoomPanel;

    [Header("Room List Panel")]
    public GameObject roomListPanel;

    public GameObject roomListContent;
    public GameObject roomListEntryPrefab;

    [Header("Inside Room Panel")]
    public GameObject insideRoomPanel;

    public Button startGameButton;
    public GameObject playerListEntryPrefab;

    private int MaxPlayers = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
