using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public Button button; // === 스텟창 버튼 할당 ===

    void Awake()
    {
        button.onClick.AddListener(ShowStatus);
    }

    private void ShowStatus()
    {
        UIManager.Instance.MainMenu.OpenStatus();
    }
}
