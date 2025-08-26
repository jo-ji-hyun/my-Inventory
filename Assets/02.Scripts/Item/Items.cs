using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    [HideInInspector]
    public int id; // === 아이템 식별 번호 ===

    public TextMeshProUGUI equipped;     // === 장착중 표시 ===

    private bool _isequipped;  // === 장착 여부 ===

    private void UpdateEquipped()
    {
        equipped.text = _isequipped ? "E" : "";
    }

    // === 버튼 클릭시 호출 ===
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
