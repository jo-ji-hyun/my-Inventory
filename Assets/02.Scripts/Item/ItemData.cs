using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory Item")]
public class ItemData : ScriptableObject
{
    [Header("info")]
    public int id;                 // === �ĺ� ��ȣ ===
    public string itemName;        // === ������ �̸� ===
    public int price;              // === ���� ===
    public Sprite icon;            // === ������ ===

    [Header("status")]             // === ���ݷ�,����,ü��,ũ��Ƽ�� ===
    public int atk;    
    public int def;
    public int hp;
    public int cri;

}
