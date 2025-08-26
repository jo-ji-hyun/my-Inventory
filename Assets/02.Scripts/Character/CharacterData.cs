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
    public int Money { get; private set; }          // === ĳ�� ���� ===

    // === Īȣ, �̸�, ����, ����ġ, ���� ===
    public CharacterData(string newtitle, string newname, int newlevel, int newexp, string newinfo, int newmoney)
    {
        Title = newtitle;
        Name = newname;
        Level = newlevel;
        Exp = newexp;
        Info = newinfo;
        Money = newmoney;
    }
}
