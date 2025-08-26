using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    [HideInInspector]
    public int id; // === ������ �ĺ� ��ȣ ===

    public TextMeshProUGUI equipped;     // === ������ ǥ�� ===

    private bool _isequipped;  // === ���� ���� ===

    private void UpdateEquipped()
    {
        equipped.text = _isequipped ? "E" : "";
    }

    // === ��ư Ŭ���� ȣ�� ===
    public void OnClick()
    {
        if (_isequipped == false)
        {
            _isequipped = true;
            UpdateEquipped();
        }
        else
        {
            _isequipped = false;
            UpdateEquipped();
        }

    }

}
