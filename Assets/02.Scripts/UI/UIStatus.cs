using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public Button button; // === ����â ��ư �Ҵ� ===

    void Awake()
    {
        button.onClick.AddListener(ShowStatus);
    }

    private void ShowStatus()
    {
        UIManager.Instance.MainMenu.OpenStatus();
    }
}
