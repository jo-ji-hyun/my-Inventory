using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public Button button; // === 스텟창 버튼 할당 ===

    [Header("Status")]    // === atk,def,hp,critical ===
    public TextMeshProUGUI atk;
    public TextMeshProUGUI def;
    public TextMeshProUGUI hp;
    public TextMeshProUGUI cri;

    void Awake()
    {
        button.onClick.AddListener(ShowStatus);

        if(GameManager.Instance != null && GameManager.Instance.Player != null)
        {
            UIChange();
        }
    }

    private void ShowStatus()
    {
        UIManager.Instance.MainMenu.OpenStatus();
    }

    // === Status UI들 갱신 ===
    public void UIChange()
    {
        atk.text = $"공격력 \n{GameManager.Instance.Player.Atk}";
        def.text = $"방어력 \n{GameManager.Instance.Player.Def}";
        hp.text = $"체력 \n{GameManager.Instance.Player.Hp}";
        cri.text = $"크리티컬 \n{GameManager.Instance.Player.Cri}";
    }
}
