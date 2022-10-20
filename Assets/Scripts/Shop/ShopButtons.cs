using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopButtons : MonoBehaviour
{
    public int itemShopType;
    [SerializeField] private GameObject itemSellText;
    [SerializeField] private GameObject itemNotEnoughText;


    private void Start()
    {
        itemNotEnoughText.SetActive(false);
        itemSellText.SetActive(false);
    }

    private void OnMouseOver()
    {
        //wood
        if(itemShopType == 1)
        {
            itemSellText.SetActive(true);
            if (WoodCounter.wood == 0)
            {
                itemNotEnoughText.SetActive(true);
            }


            if (Input.GetMouseButtonDown(0) && WoodCounter.wood != 0)
            {
                sellWood();
            }

            if (Input.GetMouseButtonDown(1) && WoodCounter.wood != 0)
            {
                sellAllWood();
            }
        }
        //ore
        else if(itemShopType == 2)
        {     
            itemSellText.SetActive(true);
            if (OreCounter.ore == 0)
            {
                itemNotEnoughText.SetActive(true);
            }

            if (Input.GetMouseButtonDown(0) && OreCounter.ore != 0)
            {
                sellOre();
            }

            if (Input.GetMouseButtonDown(1) && OreCounter.ore != 0)
            {
                sellAllOre();
            }
        }
        else if(itemShopType == 3)
        {
            if (Input.GetMouseButtonDown(0) && bag.gold != 0)
            {
                getRope();
            }
        }
    }

    private void OnMouseExit()
    {  
        itemSellText.SetActive(false);
        itemNotEnoughText.SetActive(false);
    }

    public void sellWood()
    {
        WoodCounter.wood -= 1;
        bag.gold += 1;
    }

    public void sellAllWood()
    {
        bag.gold += WoodCounter.wood;
        WoodCounter.wood -= WoodCounter.wood;
    }
    public void sellOre()
    {
        OreCounter.ore -= 1;
        bag.gold += 1;
    }

    public void sellAllOre()
    {
        bag.gold += OreCounter.ore;
        OreCounter.ore -= OreCounter.ore;
    }

    public void getRope()
    {
        bag.gold--;
        bag.rope++;
    }
}
