using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    // === UI���� ===
    [SerializeField]
    private UIMainMenu mainMenu;
    [SerializeField]
    private UIStatus status;
    [SerializeField]
    private UIInventory inventory;

    // === �ı��ϸ� �ȵ� ===
    protected override bool IsDestroy => false;

    protected override void Awake()
    {
        base.Awake();
    }

}
