using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData 
{
    public string Title{ get; private set; }          // === Īȣ ===
    public string Name { get; private set; }          // === �̸� ===
    public int Level { get; private set; }            // === ���� ===
    public int Exp { get; private set; }              // === ����ġ ===
    public string Info { get; private set; }          // === ĳ�� ���� ===
    public int Money { get; private set; }            // === ĳ�� ������ ===

    // === �÷��̾� ���� ===
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Hp { get; private set; }
    public int Cri { get; private set; }

    // === Īȣ, �̸�, ����, ����ġ, ���� ===
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
    }
}
