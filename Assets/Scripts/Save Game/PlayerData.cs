using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
    //BAG ITEMS
    public int gold;
    public int wood;
    public int axe;
    public int ore;
    public int pickaxe;
    public int bars;

    //WEAPONS
    public int sword;
    public int shield;
    public int bow;
    public int arrow;
    public int armor;

    //MATERIALS
    public int swordBlade;
    public int swordHilt;
    public int bowstring;
    public int arrowshaft;
    public int arrowtip;
    public int rope;

    //COMPLETED
    public bool completed;
    //TOOLS
    public int axeCost;
    public int pickaxeCost;

    //LEVELS
    public int woodlevel;
    public int orelevel;
    public int smithlevel;
    public int craftlevel;

    //TEMP XP
    public int woodxpT;
    public int orexpT;
    public int smithxpT;
    public int craftxpT;

    //XP
    public int woodxp;
    public int orexp;
    public int smithxp;
    public int craftxp;

    public int totalxp;

    //TUTORIAL
    public bool loreTutorial;

    public bool woodcuttingTutorial;
    public bool miningTutorial;
    public bool smeltingTutorial;
    public bool craftingTutorial;

    public bool inventoryTutorial;
    public bool shopTutorial;
    public bool playerstatsTutorial;







    public PlayerData()
    {
        //BAG
        gold = bag.gold;
        wood = WoodCounter.wood;
        axe = WoodCounter.axeLevel;
        ore = OreCounter.ore;
        pickaxe = OreCounter.pickaxeLevel;
        bars = bag.bars;

        //WEAPONS
        sword = bag.sword;
        shield = bag.shield;
        bow = bag.bow;
        arrow = bag.arrow;
        armor = bag.armor;

        //MATERIALS
        swordBlade = bag.swordBlade;
        swordHilt = bag.swordHilt;
        bowstring = bag.bowstring;
        arrowshaft = bag.arrowshaft;
        arrowtip = bag.arrowtip;
        rope = bag.rope;

        //COMPLETED
        completed = bag.completed;


        //TOOLS
        axeCost = shopItems.axeUpgradeCost;
        pickaxeCost = shopItems.pickaxeUpgradeCost;

        //LEVELS
        woodlevel = PlayerLevels.WoodcuttingLevel;
        orelevel = PlayerLevels.MiningLevel;
        smithlevel = PlayerLevels.SmeltingLevel;
        craftlevel = PlayerLevels.CraftingLevel;

        //TEMP XP
        woodxpT = PlayerLevels.WoodcuttingXPtemp;
        orexpT = PlayerLevels.MiningXPtemp;
        smithxpT = PlayerLevels.SmeltingXPtemp;
        craftxpT = PlayerLevels.CraftingXPtemp;

        //XP
        woodxp = PlayerLevels.WoodcuttingXP;
        orexp = PlayerLevels.MiningXP;
        smithxp = PlayerLevels.SmeltingXP;
        craftxp = PlayerLevels.CraftingXP;

        totalxp = PlayerLevels.totalXP;

        //TUTORIAL
        loreTutorial = TutorialScenes.visitedLore;

        woodcuttingTutorial = TutorialScenes.visitedWoodbutting;
        miningTutorial = TutorialScenes.visitedMining;
        smeltingTutorial = TutorialScenes.visitedSmelting;
        craftingTutorial = TutorialScenes.visitedCrafting;

        inventoryTutorial = TutorialScenes.visitedInventory;
        shopTutorial = TutorialScenes.visitedShop;
        playerstatsTutorial = TutorialScenes.visitedPlayerstats;
    }
}
