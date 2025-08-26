using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector]
    public CharacterData Player { get; private set; }

    // === 싱글톤 선언(파괴 x) ===
    protected override bool IsDestroy => false;

    protected override void Awake()
    {
        base.Awake();

        SetData();
    }

    private void SetData()
    {
        CharacterData newPlayer = new("초보자", "조지현", 1, 0, "코딩의 노예(진)", 20000, 5, 5, 50, 15);
        Player = newPlayer;
    }
}
