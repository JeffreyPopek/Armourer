using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopMenu : MonoBehaviour
{

    //RESOURCE COUNT
    [SerializeField] private TMP_Text goldAmount;
    [SerializeField] private GameObject woodHolder;
    [SerializeField] private TMP_Text woodAmount;
    [SerializeField] private GameObject oreHolder;
    [SerializeField] private TMP_Text oreAmount;
    [SerializeField] private GameObject ropeHolder;
    [SerializeField] private TMP_Text ropeAmount;


    //WHEN YOU HOVER OVER SWITCH BUTTON THIS TEXT SHOWS
    [SerializeField] private GameObject infoText;

    //CHANGES BASED ON WHAT SHOP TYPE YOU ARE ON
    [SerializeField] private TMP_Text shopType;

    //WOOD SHOP
    [SerializeField] private GameObject woodShop;

    //ORE SHOP
    [SerializeField] private GameObject oreShop;

    //ROPE SHOP
    [SerializeField] private GameObject ropeShop;
    [SerializeField] private GameObject ropeCanvasHolder;


    //WHEN FIRST CLICK IS TRUE IT WILL SHOW XP, SECOND CLICK THE LEVELS, AND THIRD CLICK TOOL LEVELS
    private bool firstclick = true;
    private bool secondclick = false;
    private bool thirdclick = false;



    void Start()
    {
        goldAmount.text = bag.gold.ToString();
        woodAmount.text = WoodCounter.wood.ToString();
        oreAmount.text = OreCounter.ore.ToString();
        ropeAmount.text = bag.rope.ToString();

        loadWoodShop();
    }

    private void Update()
    {
        goldAmount.text = bag.gold.ToString();
        woodAmount.text = WoodCounter.wood.ToString();
        oreAmount.text = OreCounter.ore.ToString();
        ropeAmount.text = bag.rope.ToString();
    }


    //order: wood, ore, rope
    public void OnMouseDown()
    {
        if (firstclick == true)
        {
            firstclick = false;
            secondclick = true;

            loadOreShop();
        }
        else if (secondclick == true)
        {
            secondclick = false;
            thirdclick = true;

            loadRopeShop();
        }
        else if (thirdclick == true)
        {

            firstclick = true;
            thirdclick = false;

            loadWoodShop();
        }
    }

    private void loadWoodShop()
    {
        woodHolder.SetActive(true);
        oreHolder.SetActive(false);
        ropeHolder.SetActive(false);

        ropeCanvasHolder.SetActive(false);

        //DISABLE INFO TEXT
        infoText.SetActive(false);

        shopType.text = "Woodcutting";

        //WOOD SHOP
        woodShop.SetActive(true);

        //ORE SHOP
        oreShop.SetActive(false);

        //ROPE SHOP
        ropeShop.SetActive(false);
    }

    private void loadOreShop()
    {
        woodHolder.SetActive(false);
        oreHolder.SetActive(true);
        ropeHolder.SetActive(false);

        ropeCanvasHolder.SetActive(false);

        shopType.text = "Mining";

        //WOOD SHOP
        woodShop.SetActive(false);

        //ORE SHOP
        oreShop.SetActive(true);

        //ROPE SHOP
        ropeShop.SetActive(false);
    }

    private void loadRopeShop()
    {
        woodHolder.SetActive(false);
        oreHolder.SetActive(false);
        ropeHolder.SetActive(true);

        ropeCanvasHolder.SetActive(true);

        shopType.text = "Rope";

        //WOOD SHOP
        woodShop.SetActive(false);

        //ORE SHOP
        oreShop.SetActive(false);

        //ROPE SHOP
        ropeShop.SetActive(true);
    }

   
    private void OnMouseEnter()
    {
        infoText.SetActive(true);
    }

    private void OnMouseExit()
    {
        infoText.SetActive(false);
    }
}
