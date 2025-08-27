using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
    public Image expBar;                    // === ����ġ �� ===
    public TextMeshProUGUI exp;             // === ����ġ ===
    public TextMeshProUGUI info;            // === ���� ===

    private void Start()
    {
        if(GameManager.Instance != null && GameManager.Instance.Player != null)
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
        money.text = $"{GameManager.Instance.Player.Money:N0}";
        title.text = $"{GameManager.Instance.Player.Title}";
        characterName.text = $"{GameManager.Instance.Player.Name}";
        level.text = $"Lv.{GameManager.Instance.Player.Level}";
        expBar.fillAmount = GameManager.Instance.Player.Exp / GameManager.Instance.Player.Level * 5;
        exp.text = $"{GameManager.Instance.Player.Exp} / {GameManager.Instance.Player.Level * 5}"; // �ϴ� ������� 5��� ����
        info.text = $"{GameManager.Instance.Player.Info}";
    }
}
