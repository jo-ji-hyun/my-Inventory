using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData 
{
    public string title;         // === 칭호 ===
    public string name;          // === 이름 ===
    public int level;            // === 레벨 ===
    public int exp;              // === 경험치 ===
    public string info;          // === 캐릭 정보 ===

    // === 칭호, 이름, 레벨, 경험치, 정보 ===
    public CharacterData(string newtitle, string newname, int newlevel, int newexp, string newinfo)
    {
        title = newtitle;
        name = newname;
        level = newlevel;
        exp = newexp;
        info = newinfo;
    }
}
