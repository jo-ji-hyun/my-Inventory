using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    // === UI¿¬°á ===
    [SerializeField]
    private UIMainMenu mainMenu;
    public UIMainMenu MainMenu { get { return mainMenu; } }

    [SerializeField]
    private UIStatus status;
    public UIStatus Status { get { return status; } }

    [SerializeField]
    private UIInventory inventory;
    public UIInventory UIInventory { get { return inventory; } }

    [HideInInspector]
    public CharacterData character;

    // === ÆÄ±«ÇÏ¸é ¾ÈµÊ ===
    protected override bool IsDestroy => false;

    protected override void Awake()
    {
        base.Awake();

        mainMenu.OpenMainMenu();
    }

}
