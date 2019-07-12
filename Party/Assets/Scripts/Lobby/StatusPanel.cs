using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class StatusPanel : MonoBehaviour
{
    private readonly string connectionStatusMessage = "    Status de conexion: ";

    [Header("UI References")]
    public Text ConnectionStatusText;

    #region UNITY
    public void Update()
    {
        ConnectionStatusText.text = connectionStatusMessage + PhotonNetwork.NetworkClientState;
    }
    #endregion
}
