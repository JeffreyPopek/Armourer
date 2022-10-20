using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLevels
{
    //save all of this
    public static int WoodcuttingLevel = 1;
    public static int MiningLevel = 1;
    public static int SmeltingLevel = 1;
    public static int CraftingLevel = 1;

    public static int WoodcuttingXPtemp = 0;
    public static int MiningXPtemp = 0;
    public static int SmeltingXPtemp = 0;
    public static int CraftingXPtemp = 0;


    //show in player stats, also keeps xp so it doesnt reset
    public static int WoodcuttingXP = 0;
    public static int MiningXP = 0;
    public static int SmeltingXP = 0;
    public static int CraftingXP = 0;

    public static int totalXP = 0;

    public static int XPCap = 100;
}

public class PlayerStats : MonoBehaviour
{
    //Levels
    [SerializeField] private TMP_Text woodcuttingLevel;
    [SerializeField] private TMP_Text miningLevel;
    [SerializeField] private TMP_Text smeltingLevel;
    [SerializeField] private TMP_Text craftingLevel;


    //XP
    [SerializeField] private TMP_Text totalXP;
    [SerializeField] private TMP_Text woodXP;
    [SerializeField] private TMP_Text oreXP;
    [SerializeField] private TMP_Text smithXP;
    [SerializeField] private TMP_Text craftXP;

    //Start is called before the first frame update
    void Start()
    {
        //set total xp
        PlayerLevels.totalXP = PlayerLevels.WoodcuttingXP + PlayerLevels.MiningXP + PlayerLevels.SmeltingXP + PlayerLevels.CraftingXP;

        //LEVELS
        woodcuttingLevel.text = PlayerLevels.WoodcuttingLevel.ToString();
        miningLevel.text = PlayerLevels.MiningLevel.ToString();
        smeltingLevel.text = PlayerLevels.SmeltingLevel.ToString();
        craftingLevel.text = PlayerLevels.CraftingLevel.ToString();


        //XP
        totalXP.text = PlayerLevels.totalXP.ToString();
        woodXP.text = PlayerLevels.WoodcuttingXP.ToString();
        oreXP.text = PlayerLevels.MiningXP.ToString();
        smithXP.text = PlayerLevels.SmeltingXP.ToString();
        craftXP.text = PlayerLevels.CraftingXP.ToString();



    }

    void Update()
    {
        //LEVELS
        woodcuttingLevel.text = PlayerLevels.WoodcuttingLevel.ToString();
        miningLevel.text = PlayerLevels.MiningLevel.ToString();
        smeltingLevel.text = PlayerLevels.SmeltingLevel.ToString();
        craftingLevel.text = PlayerLevels.CraftingLevel.ToString();

        //XP
        totalXP.text = PlayerLevels.totalXP.ToString();
        woodXP.text = PlayerLevels.WoodcuttingXP.ToString();
        oreXP.text = PlayerLevels.MiningXP.ToString();
        smithXP.text = PlayerLevels.SmeltingXP.ToString();
        craftXP.text = PlayerLevels.CraftingXP.ToString();
    }
}
