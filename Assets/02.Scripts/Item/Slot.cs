using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [HideInInspector]
    public int id;                      // === ������ �ĺ� ��ȣ ===

    [Header("Slot")]
    public Image icon;                  // === ������ ǥ�� ===
    public TextMeshProUGUI equipped;    // === ������ ǥ�� ===

    private bool _isequipped;           // === ���� ���� ===

    private void Start()
    {
        icon.sprite = GameManager.Instance.allitems[id].icon;

        UpdateEquipped();
    }

    private void UpdateEquipped()
    {
        equipped.text = (_isequipped == true) ? "E" : "";
    }

    // === ��ư Ŭ���� ȣ�� ===
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
