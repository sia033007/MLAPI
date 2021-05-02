using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class NetworkSample : MonoBehaviour
{
    private void OnGUI() {
        if(GUILayout.Button("Client")) NetworkManager.Singleton.StartClient();
        if(GUILayout.Button("Host")) NetworkManager.Singleton.StartHost();
    }
}
