using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyUIManager : MonoBehaviour
{
    [SerializeField] private LobbyPanelBase[] lobbyPanels;

    private void Start()
    {
        foreach (var panel in lobbyPanels)
        {
            panel.Init(this);
        }
    }

    public void ShowPanel(LobbyPanelBase.LobbyPanelType lobbyType)
    {
        foreach(var panel in lobbyPanels)
        {
            if (panel.panelType == lobbyType)
            {
                panel.ShowPanel();
                break;
            }
        }
    }
}
