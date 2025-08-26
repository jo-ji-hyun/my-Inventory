using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    // === UI¿¬°á ===
    [SerializeField]
    private UIMainMenu mainMenu;
    [SerializeField]
    private UIStatus status;
    [SerializeField]
    private UIInventory inventory;

    // === ÆÄ±«ÇÏ¸é ¾ÈµÊ ===
    protected override bool IsDestroy => false;

    protected override void Awake()
    {
        base.Awake();
    }

}
