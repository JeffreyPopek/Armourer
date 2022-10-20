using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InventoryItemHover : MonoBehaviour
{

    [SerializeField] private GameObject ItemTextHolder;
    [SerializeField] private TMP_Text itemName;

    public int itemType;

    // Start is called before the first frame update
    void Start()
    {
        ItemTextHolder.SetActive(false);
    }

    private void OnMouseOver()
    {
        ItemTextHolder.SetActive(true);
        if(itemType == 1)
        {
            itemName.text = "Wood x" + WoodCounter.wood;
        }
        else if(itemType == 2)
        {
            itemName.text = "Ore x" + OreCounter.ore;
        }
        else if (itemType == 3)
        {
            itemName.text = "Bars x" + bag.bars;
        }
        else if (itemType == 4)
        {
            itemName.text = "Rope x" + bag.rope;
        }
        else if (itemType == 5)
        {
            itemName.text = "Gold x" + bag.gold;
        }
        else if (itemType == 6)
        {
            itemName.text = "Sword Blade x" + bag.swordBlade;
        }
        else if (itemType == 7)
        {
            itemName.text = "Sword Hilt x" + bag.swordHilt;
        }
        else if (itemType == 8)
        {
            itemName.text = "Bowstring x" + bag.bowstring;
        }
        else if (itemType == 9)
        {
            itemName.text = "Arrow Shaft x" + bag.arrowshaft;
        }
        else if (itemType == 10)
        {
            itemName.text = "Arrow Tip x" + bag.arrowtip;
        }
        else if (itemType == 11)
        {
            itemName.text = "Sword x" + bag.sword;
        }
        else if (itemType == 12)
        {
            itemName.text = "Shield x" + bag.shield;
        }
        else if (itemType == 13)
        {
            itemName.text = "Bow x" + bag.bow;
        }
        else if (itemType == 14)
        {
            itemName.text = "Arrow x" + bag.arrow;
        }
        else if (itemType == 15)
        {
            itemName.text = "Armor x" + bag.armor;
        }
    }

    private void OnMouseExit()
    {
        ItemTextHolder.SetActive(false);
    }
}
