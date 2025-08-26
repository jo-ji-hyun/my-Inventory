using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector]
    public CharacterData Player { get; private set; }

    // === �̱��� ����(�ı� x) ===
    protected override bool IsDestroy => false;

    protected override void Awake()
    {
        base.Awake();

        SetData();
    }

    private void SetData()
    {
        CharacterData newPlayer = new("�ʺ���", "������", 1, 0, "�ڵ��� �뿹(��)", 20000, 5, 5, 50, 15);
        Player = newPlayer;
    }
}
