using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bag
{
    public static int gold = 0;
    public static int bars = 0;

    //weapon items
    public static int sword = 0;
    public static int shield = 0;
    public static int bow = 0;
    public static int arrow = 0;
    public static int armor = 0;

    //weapon item materials
    public static int swordBlade = 0;
    public static int swordHilt = 0;
    public static int bowstring = 0;
    public static int arrowshaft = 0;
    public static int arrowtip = 0;
    public static int rope = 0;

    //to check if you won
    public static bool completed = false;
}

public class Inventory : MonoBehaviour
{
    //WHEN YOU HOVER OVER SWITCH BUTTON THIS TEXT SHOWS
    [SerializeField] private GameObject itemText;

    //CHANGES BASED ON WHAT INVENTORY TYPE YOU ARE ON
    [SerializeField] private TMP_Text itemTypeText;

    //RESOURCES
    [SerializeField] private GameObject resourcesMenu;

    //MATERIALS
    [SerializeField] private GameObject materialsMenu;

    //WEAPONS
    [SerializeField] private GameObject weaponsMenu;

    //WHEN FIRST CLICK IS TRUE IT WILL SHOW THE RESOURCES, SECOND CLICK THE MATERIALS, AND THIRD CLICK THE WEAPONS
    private bool firstclick = true;
    private bool secondclick = false;
    private bool thirdclick = false;



    void Start()
    {
        //DISABLE INFO TEXT
        itemText.SetActive(false);

        itemTypeText.text = "Resources";

        //RESOURCES
        resourcesMenu.SetActive(true);

        //MATERIALS
        materialsMenu.SetActive(false);

        //WEAPONS
        weaponsMenu.SetActive(false);
    }

    public void OnMouseDown()
    {
        if (firstclick == true)
        {
            firstclick = false;
            secondclick = true;
            thirdclick = false;

            itemTypeText.text = "Materials";


            //RESOURCES
            resourcesMenu.SetActive(false);

            //MATERIALS
            materialsMenu.SetActive(true);

            //WEAPONS
            weaponsMenu.SetActive(false);

        }
        else if (secondclick == true)
        {
            firstclick = false;
            secondclick = false;
            thirdclick = true;

            itemTypeText.text = "Weapons";

            //RESOURCES
            resourcesMenu.SetActive(false);

            //MATERIALS
            materialsMenu.SetActive(false);

            //WEAPONS
            weaponsMenu.SetActive(true);
        }
        else if (thirdclick == true)
        {
            firstclick = true;
            secondclick = false;
            thirdclick = false;

            itemTypeText.text = "Resources";

            //RESOURCES
            resourcesMenu.SetActive(true);

            //MATERIALS
            materialsMenu.SetActive(false);

            //WEAPONS
            weaponsMenu.SetActive(false);
        }
    }

    private void OnMouseEnter()
    {
        itemText.SetActive(true);
    }

    private void OnMouseExit()
    {
        itemText.SetActive(false);
    }
}
