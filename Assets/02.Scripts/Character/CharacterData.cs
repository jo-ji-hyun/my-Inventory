using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData 
{
    public string Title{ get; private set; }          // === 칭호 ===
    public string Name { get; private set; }          // === 이름 ===
    public int Level { get; private set; }            // === 레벨 ===
    public int Exp { get; private set; }              // === 경험치 ===
    public string Info { get; private set; }          // === 캐릭 정보 ===
    public int Money { get; private set; }            // === 캐릭 소지금 ===

    // === 플레이어 스텟 ===
    public int Atk { get; set; }
    public int Def { get; set; }
    public int Hp { get; set; }
    public int Cri { get; set; }


    public List<ItemData> Inventory;

    // === 칭호, 이름, 레벨, 경험치, 정보 ===
    public CharacterData(string newtitle, string newname, int newlevel, int newexp, string newinfo, int newmoney, int newatk, int newdef, int newhp, int newcri)
    {
        Title = newtitle;
        Name = newname;
        Level = newlevel;
        Exp = newexp;
        Info = newinfo;
        Money = newmoney;
        Atk = newatk;
        Def = newdef;
        Hp = newhp;
        Cri = newcri;

        Inventory = new List<ItemData> ();
    }

    public void AddItem(ItemData item)
    {
        Inventory.Add(item);
    }

    public void Equip(ItemData item)
    {
        Atk += item.atk;
        Def += item.def;
        Hp += item.hp;
        Cri += item.cri;
    }

    public void UnEquip(ItemData item)
    {
        Atk -= item.atk;
        Def -= item.def;
        Hp -= item.hp;
        Cri -= item.cri;
    }
}
