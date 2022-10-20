using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bar : MonoBehaviour
{
    [SerializeField] private TMP_Text XPAmount;
    [SerializeField] private TMP_Text level;
    public Slider slider;
    public int skillType;
    private void Start()
    {
        if (skillType == 1)
        {
            XPAmount.text = PlayerLevels.WoodcuttingXP.ToString();
            level.text = PlayerLevels.WoodcuttingLevel.ToString();
        }
        else if (skillType == 2)
        {
            XPAmount.text = PlayerLevels.MiningXP.ToString();
            level.text = PlayerLevels.MiningLevel.ToString();
        }
        else if (skillType == 3)
        {
            XPAmount.text = PlayerLevels.SmeltingXP.ToString();
            level.text = PlayerLevels.SmeltingLevel.ToString();
        }
        else if (skillType == 4)
        {
            XPAmount.text = PlayerLevels.CraftingXP.ToString();
            level.text = PlayerLevels.CraftingLevel.ToString();
        }
    }

    private void Update()
    {
        if (skillType == 1)
        {
            if (PlayerLevels.WoodcuttingXPtemp >= PlayerLevels.XPCap)
            {
                levelUp();
            }
            slider.value = PlayerLevels.WoodcuttingXPtemp;
            XPAmount.text = PlayerLevels.WoodcuttingXPtemp.ToString();
            level.text = PlayerLevels.WoodcuttingLevel.ToString();
        }
        else if (skillType == 2)
        {
            if (PlayerLevels.MiningXPtemp >= PlayerLevels.XPCap)
            {
                levelUp();
            }
            slider.value = PlayerLevels.MiningXPtemp;
            XPAmount.text = PlayerLevels.MiningXPtemp.ToString();
            level.text = PlayerLevels.MiningLevel.ToString();
        }
        else if (skillType == 3)
        {
            if (PlayerLevels.SmeltingXPtemp >= PlayerLevels.XPCap)
            {
                levelUp();
            }
            slider.value = PlayerLevels.SmeltingXPtemp;
            XPAmount.text = PlayerLevels.SmeltingXPtemp.ToString();
            level.text = PlayerLevels.SmeltingLevel.ToString();
        }
        else if (skillType == 4)
        {
            if (PlayerLevels.CraftingXPtemp >= PlayerLevels.XPCap)
            {
                levelUp();
            }
            slider.value = PlayerLevels.CraftingXPtemp;
            XPAmount.text = PlayerLevels.CraftingXPtemp.ToString();
            level.text = PlayerLevels.CraftingLevel.ToString();
        }
    } 

    public void levelUp()
    {
        if(skillType == 1)
        {
            PlayerLevels.WoodcuttingLevel++;
            PlayerLevels.WoodcuttingXPtemp = 0;
        }
        else if(skillType == 2)
        {
            PlayerLevels.MiningLevel++;
            PlayerLevels.MiningXPtemp = 0;
        }
        else if (skillType == 3)
        {
            PlayerLevels.SmeltingLevel++;
            PlayerLevels.SmeltingXPtemp = 0;
        }
        else if (skillType == 4)
        {
            PlayerLevels.CraftingLevel++;
            PlayerLevels.CraftingXPtemp = 0;
        }
    }
}
