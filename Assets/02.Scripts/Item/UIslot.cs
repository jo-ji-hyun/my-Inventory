using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIslot : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefab;   // === 생성할 슬롯 ===

    private int _slotnumber = 10;   // === 생성할 갯수 ===

    public List<GameObject> _slotList;

    private void Start()
    {
        if(GameManager.Instance != null)
        {
            SetItem();
        }
    }
        
    void SetItem()
    {
        _slotList = new List<GameObject>();

        for (int i = 0; i < _slotnumber; i++)
        {
            GameObject slot = Instantiate(slotPrefab, transform);
            _slotList.Add(slot);
        }

        RefreshUI();
    }

    void RefreshUI()
    {
        for (int i = 0; i < _slotnumber; i++)
        {
            // === id를 부여 ===
            Slot slot = _slotList[i].GetComponent<Slot>();

            if(i < GameManager.Instance.allitems.Count)
            {
                slot.id = i;
            }
        }
    }
}
