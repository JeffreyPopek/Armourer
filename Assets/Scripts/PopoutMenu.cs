using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopoutMenu : MonoBehaviour
{
    [SerializeField] private GameObject SaveButton;
    [SerializeField] private GameObject InventoryButton;
    [SerializeField] private GameObject ShopButton;
    [SerializeField] private GameObject WoodcuttingButton;
    [SerializeField] private GameObject MiningButton;
    [SerializeField] private GameObject SmithingButton;
    [SerializeField] private GameObject CraftingButton;


    private bool clicked = false;


    void Start()
    {
        SaveButton.SetActive(false);
        InventoryButton.SetActive(false);
        ShopButton.SetActive(false);
        WoodcuttingButton.SetActive(false);
        MiningButton.SetActive(false);
        SmithingButton.SetActive(false);
        CraftingButton.SetActive(false);
    }

    void Update()
    {
        if (clicked == false)
        {
            SaveButton.SetActive(false);
            InventoryButton.SetActive(false);
            ShopButton.SetActive(false);
            WoodcuttingButton.SetActive(false);
            MiningButton.SetActive(false);
            SmithingButton.SetActive(false);
            CraftingButton.SetActive(false);
        }
    }

    public void OnMouseDown()
    {
        if (clicked == true)
        {
            clicked = false;
            SaveButton.SetActive(false);
            InventoryButton.SetActive(false);
            ShopButton.SetActive(false);
            WoodcuttingButton.SetActive(false);
            MiningButton.SetActive(false);
            SmithingButton.SetActive(false);
            CraftingButton.SetActive(false);
            //Debug.Log("off");
            return;
        }

        if (clicked == false)
        {
            clicked = true;
            SaveButton.SetActive(true);
            InventoryButton.SetActive(true);
            ShopButton.SetActive(true);
            WoodcuttingButton.SetActive(true);
            MiningButton.SetActive(true);
            SmithingButton.SetActive(true);
            CraftingButton.SetActive(true);
            //Debug.Log("on");
            return;
        }

    }
}
