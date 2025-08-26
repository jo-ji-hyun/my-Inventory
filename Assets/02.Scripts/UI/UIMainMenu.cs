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
    public TextMeshProUGUI money;           // === ������ ===
    public TextMeshProUGUI title;           // === Īȣ ===
    public TextMeshProUGUI characterName;   // === �̸� ===
    public TextMeshProUGUI level;           // === ���� ===
    public TextMeshProUGUI exp;             // === ����ġ ===
    public TextMeshProUGUI info;            // === ���� ===

    private void Awake()
    {
        if(UIManager.Instance != null)
        {
            UIChange();
        }
    }

    // === �ٸ� â�� ���� �ݰ� ===
    private void Closemenu()
    {
        status.SetActive(false);
        inventory.SetActive(false);
    }

    // === �ʿ��� â�� ���� ===
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

    // === MainMenu�� UI�� ���� ===
    public void UIChange()
    {
        money.text = $"{UIManager.Instance.character.Money:N0}";
        title.text = $"{UIManager.Instance.character.Title}";
        characterName.text = $"{UIManager.Instance.character.Name}";
        level.text = $"{UIManager.Instance.character.Level}";
        exp.text = $"{UIManager.Instance.character.Exp} / {UIManager.Instance.character.Level * 5}"; // �ϴ� ������� 5��� ����
        info.text = $"{UIManager.Instance.character.Info}";
    }
}
