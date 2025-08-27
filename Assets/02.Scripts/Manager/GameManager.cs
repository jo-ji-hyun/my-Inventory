using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector]
    public CharacterData Player { get; private set; }

    public List<ItemData> allitems = new(); // === ��� �������� ���� ===

    // === �̱��� ����(�ı� x) ===
    protected override bool IsDestroy => false;

    protected override void Awake()
    {
        base.Awake();

        SetData();
    }

    public void SetData()
    {
        CharacterData newPlayer = new("�ʺ���", "������", 1, 0, "�ڵ��� �뿹(��)", 20000, 5, 5, 50, 15);
        
        Player = newPlayer;

        Player.AddItem(allitems[0]);
    }

    public void EquipItem(int num)
    {
        ItemData item = allitems[num];

        Player.Equip(item);

        UIManager.Instance.Status.UIChange();
    }

    public void UnEquipItem(int num)
    {
        ItemData item = allitems[num];

        Player.UnEquip(item);
    }
}
