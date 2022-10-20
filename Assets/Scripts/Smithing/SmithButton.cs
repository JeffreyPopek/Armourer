using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SmithButton : MonoBehaviour
{
    [SerializeField] private GameObject smeltText;
    [SerializeField] private GameObject noOreText;

    // Start is called before the first frame update
    void Start()
    {
        smeltText.SetActive(false);
        noOreText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {

    }


    private void OnMouseOver()
    {
        smeltText.SetActive(true);
        if(OreCounter.ore < 3)
        {
            noOreText.SetActive(true);
        }

        if (OreCounter.ore >= 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                smeltOre();
            }
            else if (Input.GetMouseButtonDown(1))
            {
                smeltAllOre();
            }
        }
    }

    private void OnMouseExit()
    {
        smeltText.SetActive(false);
        noOreText.SetActive(false);
    }

    private void smeltOre()
    {
        OreCounter.ore -= 2;
        bag.bars++;
        PlayerLevels.SmeltingXPtemp++;
        PlayerLevels.SmeltingXP++;
    }

    private void smeltAllOre()
    {
        int counter = 0;
        for (; OreCounter.ore >= 2; bag.bars++)
        {
            OreCounter.ore -= 2;
            counter++;
        }

        int tempLvl = 0;
        if(counter > 100 || counter + PlayerLevels.SmeltingXPtemp == 100)
        {
            for(; counter > 100; tempLvl++)
            {
                counter -= 100;
            }
            if(tempLvl != 0)
            {
                for(; tempLvl > 0; PlayerLevels.SmeltingLevel++)
                {
                    tempLvl--;
                }
            }
        }

        //IF COUNTER IS NOT GREATER THAN 100 XP THEN YOU DONT LEVEL UP AND IT JUST ADDS TO XP BAR
        PlayerLevels.SmeltingXPtemp += counter;
        PlayerLevels.SmeltingXP += counter;
        
        
    }
}
