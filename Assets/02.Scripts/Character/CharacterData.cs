using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData 
{
    public string title;         // === Īȣ ===
    public string name;          // === �̸� ===
    public int level;            // === ���� ===
    public int exp;              // === ����ġ ===
    public string info;          // === ĳ�� ���� ===

    // === Īȣ, �̸�, ����, ����ġ, ���� ===
    public CharacterData(string newtitle, string newname, int newlevel, int newexp, string newinfo)
    {
        title = newtitle;
        name = newname;
        level = newlevel;
        exp = newexp;
        info = newinfo;
    }
}
