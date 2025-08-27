using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button button;                 // === 인벤토리 버튼 할당 ===
    public GameObject miniStatus;         // === 미니 스텟창 ===

    void OnEnable()
    {
        button.onClick.AddListener(ShowInventory);
    }

    private void ShowInventory()
    {
        UIManager.Instance.MainMenu.OpenInventory();
    }

    public void ShowItemInformation()
    {
        miniStatus.SetActive(false);

        miniStatus.SetActive(true);    // === 열릴때마다 갱신되므로 껏다 키기 ===
    }
}
