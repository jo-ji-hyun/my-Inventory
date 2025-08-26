using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button button;                 // === 인벤토리 버튼 할당 ===
    public GameObject iteminfo;          // === 정보창 표시 ===

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
