using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIslot : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefab;   // === ������ ���� ===

    private int _slotnumber = 10;   // === ������ ���� ===

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
            // === id�� �ο� ===
            Slot slot = _slotList[i].GetComponent<Slot>();

            if(i < GameManager.Instance.allitems.Count)
            {
                slot.id = i;
            }
        }
    }
}
