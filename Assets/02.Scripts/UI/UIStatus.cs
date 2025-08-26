using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public Button button; // === ����â ��ư �Ҵ� ===

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

    // === Status UI�� ���� ===
    public void UIChange()
    {
        atk.text = $"���ݷ� \n{GameManager.Instance.Player.Atk}";
        def.text = $"���� \n{GameManager.Instance.Player.Def}";
        hp.text = $"ü�� \n{GameManager.Instance.Player.Hp}";
        cri.text = $"ũ��Ƽ�� \n{GameManager.Instance.Player.Cri}";
    }
}
