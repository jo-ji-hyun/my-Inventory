using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject status;
    public GameObject inventory;
    [Header("Text")]
    public TextMeshProUGUI money;           // === 소지금 ===
    public TextMeshProUGUI title;           // === 칭호 ===
    public TextMeshProUGUI characterName;   // === 이름 ===
    public TextMeshProUGUI level;           // === 레벨 ===
    public TextMeshProUGUI exp;             // === 경험치 ===
    public TextMeshProUGUI info;            // === 정보 ===

    private void Awake()
    {
        if(UIManager.Instance != null)
        {
            UIChange();
        }
    }

    // === 다른 창을 먼저 닫고 ===
    private void Closemenu()
    {
        status.SetActive(false);
        inventory.SetActive(false);
    }

    // === 필요한 창만 열기 ===
    public void OpenMainMenu()
    {
        Closemenu();
        mainmenu.SetActive(true);
    }

    public void OpenStatus()
    {
        Closemenu();

        status.SetActive(true);
    }

    public void OpenInventory()
    {
        Closemenu();

        inventory.SetActive(true);
    }

    // === MainMenu의 UI들 갱신 ===
    public void UIChange()
    {
        money.text = $"{UIManager.Instance.character.Money:N0}";
        title.text = $"{UIManager.Instance.character.Title}";
        characterName.text = $"{UIManager.Instance.character.Name}";
        level.text = $"{UIManager.Instance.character.Level}";
        exp.text = $"{UIManager.Instance.character.Exp} / {UIManager.Instance.character.Level * 5}"; // 일단 레벨비례 5배로 설정
        info.text = $"{UIManager.Instance.character.Info}";
    }
}
