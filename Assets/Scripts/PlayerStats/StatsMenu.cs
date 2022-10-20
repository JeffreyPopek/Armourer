using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsMenu : MonoBehaviour
{

    //WHEN YOU HOVER OVER SWITCH BUTTON THIS TEXT SHOWS
    [SerializeField] private GameObject infoText;

    //CHANGES BASED ON WHAT STATS TYPE YOU ARE ON
    [SerializeField] private TMP_Text statsType;

    //XP
    [SerializeField] private GameObject xpMenu;

    //LEVELS
    [SerializeField] private GameObject levelsMenu;

    //WHEN FIRST CLICK IS TRUE IT WILL SHOW XP, SECOND CLICK THE LEVELS, AND THIRD CLICK TOOL LEVELS
    private bool firstclick = true;
    private bool secondclick = false;



    void Start()
    {
        //DISABLE INFO TEXT
        infoText.SetActive(false);

        statsType.text = "XP";

        //XP
        xpMenu.SetActive(true);

        //LEVELS
        levelsMenu.SetActive(false);
    }

    public void OnMouseDown()
    {
        if (firstclick == true)
        {
            firstclick = false;
            secondclick = true;

            statsType.text = "Levels";


            //XP
            xpMenu.SetActive(false);

            //LEVELS
            levelsMenu.SetActive(true);
        }
        else if (secondclick == true)
        {
            firstclick = true;
            secondclick = false;

            statsType.text = "XP";

            //XP
            xpMenu.SetActive(true);

            //LEVELS
            levelsMenu.SetActive(false);
        }
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
