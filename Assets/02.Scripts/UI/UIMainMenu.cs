using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject status;
    public GameObject inventory;

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
}
