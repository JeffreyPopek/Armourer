using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shopItems
{
    public static int axeUpgradeCost = 50;
    public static int pickaxeUpgradeCost = 50;
    public static int upgradeMultiplier = 2;
}
public class Shop : MonoBehaviour
{
    [SerializeField] private TMP_Text goldAmount;
    [SerializeField] private TMP_Text itemAmount;
    [SerializeField] private TMP_Text toolLevel;

    public int shopType;

    void Start()
    {
        goldAmount.text = bag.gold.ToString();

        if(shopType == 1)
        {
            itemAmount.text = WoodCounter.wood.ToString();
            toolLevel.text = WoodCounter.axeLevel.ToString();
        }
        else if(shopType == 2)
        {
            itemAmount.text = OreCounter.ore.ToString();
            toolLevel.text = OreCounter.pickaxeLevel.ToString();
        }
        
    }

    void Update()
    {
        goldAmount.text = bag.gold.ToString();

        if (shopType == 1)
        {
            itemAmount.text = WoodCounter.wood.ToString();
            toolLevel.text = WoodCounter.axeLevel.ToString();
        }
        else if (shopType == 2)
        {
            itemAmount.text = OreCounter.ore.ToString();
            toolLevel.text = OreCounter.pickaxeLevel.ToString();
        }
    }


}
