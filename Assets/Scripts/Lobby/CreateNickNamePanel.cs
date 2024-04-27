using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateNickNamePanel : LobbyPanelBase
{
    [Header("CreateNickNamePanel Vars")]
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button createNickNameBtn;

    private const int MIN_CHARACTER_FOR_NICKNAME = 2;

    public override void Init(LobbyUIManager uIManager)
    {
        base.Init(uIManager);
        createNickNameBtn.interactable = false;
        createNickNameBtn.onClick.AddListener(OnClickCreateNickName);
        inputField.onValueChanged.AddListener(OnInputValueChanged);
    }

    private void OnInputValueChanged(string nickNameByPlayer)
    {
        createNickNameBtn.interactable = nickNameByPlayer.Length >= MIN_CHARACTER_FOR_NICKNAME;
    }

    private void OnClickCreateNickName()
    {
        var nickName = inputField.text;
        if (nickName.Length >= MIN_CHARACTER_FOR_NICKNAME)
        {
            base.ClosePanel();
            lobbyUIManager.ShowPanel(LobbyPanelType.MiddleSectionPanel);
        }
    }
}
