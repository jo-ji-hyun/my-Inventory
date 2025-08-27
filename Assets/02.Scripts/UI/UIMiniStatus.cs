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

    private void OnEnable() // === 킬때만 작동 ===
    {
        if(GameManager.Instance.Player.Inventory.Count > 0)
        {
            ItemData item = GameManager.Instance.Player.Inventory[0];

            itemAtk.text = $"{item.atk}";
            itemDef.text = $"{item.def}";
            itemHp.text = $"{item.hp}";
            itemCri.text = $"{item.cri}";

            GameManager.Instance.Player.Inventory.RemoveAt(0);
        }

    }

}
