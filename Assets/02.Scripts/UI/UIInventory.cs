using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button button;                 // === �κ��丮 ��ư �Ҵ� ===
    public GameObject miniStatus;         // === �̴� ����â ===

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

        miniStatus.SetActive(true);    // === ���������� ���ŵǹǷ� ���� Ű�� ===
    }
}
