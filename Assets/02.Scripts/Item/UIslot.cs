using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIslot : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefab;   // === ������ ���� ===

    private int _slotnumber = 20;   // === ������ ���� ===

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
        Debug.Log("slot ����");
    }
}
