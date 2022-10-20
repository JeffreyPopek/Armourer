using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeButtons : MonoBehaviour
{
    public int shopItemType;
    [SerializeField] private GameObject buyText;
    [SerializeField] private GameObject notEnoughText;
    [SerializeField] private TMP_Text goldUpgradeCost;


    private void Start()
    {
        notEnoughText.SetActive(false);
        buyText.SetActive(false);

        if (shopItemType == 1)
        {
            goldUpgradeCost.text = shopItems.axeUpgradeCost.ToString();
        }
        else if(shopItemType == 2)
        {
            goldUpgradeCost.text = shopItems.pickaxeUpgradeCost.ToString();
        }   
    }

    private void Update()
    {
        if(shopItemType == 1)
        {
            goldUpgradeCost.text = shopItems.axeUpgradeCost.ToString();
        }
        else if(shopItemType == 2)
        {
            goldUpgradeCost.text = shopItems.pickaxeUpgradeCost.ToString();
        }
    }
    private void OnMouseOver()
    {
        buyText.SetActive(true);
        if (shopItemType == 1)
        {
            if (bag.gold < shopItems.axeUpgradeCost)
            {
                notEnoughText.SetActive(true);
            }

            if (Input.GetMouseButtonDown(0) && (bag.gold >= shopItems.axeUpgradeCost))
            {
                levelUpAxe();               
            }     
        }
        else if(shopItemType == 2)
        {
            if (bag.gold < shopItems.pickaxeUpgradeCost)
            {
                notEnoughText.SetActive(true);
            }

            if (Input.GetMouseButtonDown(0) && (bag.gold >= shopItems.pickaxeUpgradeCost))
            {
                levelUpPickaxe();
            }

        }
        
    }

    private void OnMouseExit()
    {
        buyText.SetActive(false);
        notEnoughText.SetActive(false);
    }

    public void levelUpAxe()
    {
        bag.gold -= shopItems.axeUpgradeCost;
        WoodCounter.axeLevel++;
        shopItems.axeUpgradeCost *= shopItems.upgradeMultiplier;
    }

    public void levelUpPickaxe()
    {
        bag.gold -= shopItems.pickaxeUpgradeCost;
        OreCounter.pickaxeLevel++;
        shopItems.pickaxeUpgradeCost *= shopItems.upgradeMultiplier;
    }
}
