using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory Item")]
public class ItemData : ScriptableObject
{
    [Header("info")]
    public int id;                 // === 식별 번호 ===
    public string itemName;        // === 아이템 이름 ===
    public int price;              // === 가격 ===
    public Sprite icon;            // === 아이콘 ===

    [Header("status")]             // === 공격력,방어력,체력,크리티컬 ===
    public int atk;    
    public int def;
    public int hp;
    public int cri;

}
