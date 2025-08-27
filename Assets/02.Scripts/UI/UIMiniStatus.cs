using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIMiniStatus : MonoBehaviour
{
    [Header("Text")]
    public TextMeshProUGUI itemAtk;
    public TextMeshProUGUI itemDef;
    public TextMeshProUGUI itemHp;
    public TextMeshProUGUI itemCri;

    private void OnEnable() // === ų���� �۵� ===
    {
        if(GameManager.Instance.Player.Inventory.Count > 0)
        {
            if (GameManager.Instance.Player.Inventory[0] != null)
            {
                ItemData item = GameManager.Instance.Player.Inventory[0]; // === Player�� �κ��丮�� �׻� 0�� �ִ´�. ===

                itemAtk.text = $"{item.atk}";
                itemDef.text = $"{item.def}";
                itemHp.text = $"{item.hp}";
                itemCri.text = $"{item.cri}";
            }

        }

    }

}
