using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [HideInInspector]
    public int id;                      // === 아이템 식별 번호 ===

    [Header("Slot")]
    public Image icon;                  // === 아이콘 표시 ===
    public TextMeshProUGUI equipped;    // === 장착중 표시 ===

    private bool _isequipped;           // === 장착 여부 ===

    private void Start()
    {
        icon.sprite = GameManager.Instance.allitems[id].icon;

        UpdateEquipped();
    }

    private void UpdateEquipped()
    {
        equipped.text = (_isequipped == true) ? "E" : "";
    }

    // === 버튼 클릭시 호출 ===
    public void OnClick()
    {
        if (_isequipped == false)
        {
            _isequipped = true;

            UpdateEquipped();

            GameManager.Instance.EquipItem(id);

            UIManager.Instance.UIInventory.ShowItemInformation();
        }
        else
        {
            _isequipped = false;

            UpdateEquipped();

            GameManager.Instance.UnEquipItem(id);
        }

    }
}
