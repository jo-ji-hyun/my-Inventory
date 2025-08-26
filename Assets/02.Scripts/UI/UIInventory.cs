using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button button;                 // === �κ��丮 ��ư �Ҵ� ===
    public GameObject iteminfo;          // === ����â ǥ�� ===

    void OnEnable()
    {
        button.onClick.AddListener(ShowInventory);
    }

    private void ShowInventory()
    {
        UIManager.Instance.MainMenu.OpenInventory();
        iteminfo.SetActive(true);
    }
}
