using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector]
    public CharacterData Player { get; private set; }

    public List<ItemData> allitems = new(); // === 모든 아이템을 저장 ===

    // === 싱글톤 선언(파괴 x) ===
    protected override bool IsDestroy => false;

    protected override void Awake()
    {
        base.Awake();

        SetData();
    }

    public void SetData()
    {
        Player = new("초보자", "조지현", 1, 0, "코딩의 노예(진)", 20000, 5, 5, 50, 15)
        {
            Inventory = new List<ItemData>()
        };

    }

    public void EquipItem(int num)
    {
        ItemData item = allitems[num];

        Player.AddItem(item);

        Player.Equip(item);

        UIManager.Instance.Status.UIChange();
    }

    public void UnEquipItem(int num)
    {
        ItemData item = allitems[num];

        Player.UnEquip(item);

        Player.Inventory.Remove(item);

        UIManager.Instance.Status.UIChange();
    }
}
