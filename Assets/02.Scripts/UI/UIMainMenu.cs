using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject status;
    public GameObject inventory;
    public TextMeshProUGUI money;

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

    public void MoneyChange()
    {
        money.text = string.Format("{0:N0}", UIManager.Instance.character.Money);
    }
}
