using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public void SavePlayer()
    {
        SaveSystem.SavePlayer();
    }

    public void LoadPlayer()
    {
        //BAG
        PlayerData data = SaveSystem.LoadPlayer();
        bag.gold = data.gold;
        WoodCounter.wood = data.wood;
        WoodCounter.axeLevel = data.axe;
        OreCounter.ore = data.ore;
        OreCounter.pickaxeLevel = data.pickaxe;
        bag.bars = data.bars;

        //WEAPONS
        bag.sword = data.sword;
        bag.shield = data.shield;
        bag.bow = data.bow;
        bag.arrow = data.arrow;
        bag.armor = data.armor;

        //MATERIALS
        bag.swordBlade = data.swordBlade;
        bag.swordHilt = data.swordHilt;
        bag.bowstring = data.bowstring;
        bag.arrowshaft = data.arrowshaft;
        bag.arrowtip = data.arrowtip;
        bag.rope = data.rope;

        //FINISHED GAME
        bag.completed = data.completed;

        //TOOLS
        shopItems.axeUpgradeCost = data.axeCost;
        shopItems.pickaxeUpgradeCost = data.pickaxeCost;

        //LEVELS
        PlayerLevels.WoodcuttingLevel = data.woodlevel;
        PlayerLevels.MiningLevel = data.orelevel;
        PlayerLevels.SmeltingLevel = data.smithlevel;
        PlayerLevels.CraftingLevel = data.craftlevel;

        //TEMP XP
        PlayerLevels.WoodcuttingXPtemp = data.woodxpT;
        PlayerLevels.MiningXPtemp = data.orexpT;
        PlayerLevels.SmeltingXPtemp = data.smithxpT;
        PlayerLevels.CraftingXPtemp = data.craftxpT;

        //XP
        PlayerLevels.WoodcuttingXP = data.woodxp;
        PlayerLevels.MiningXP = data.orexp;
        PlayerLevels.SmeltingXP = data.smithxp;
        PlayerLevels.CraftingXP = data.craftxp;

        PlayerLevels.totalXP = data.totalxp;

        //TUTORIAL
        TutorialScenes.visitedLore = data.loreTutorial;

        TutorialScenes.visitedWoodbutting = data.woodcuttingTutorial;
        TutorialScenes.visitedMining = data.miningTutorial;
        TutorialScenes.visitedSmelting = data.smeltingTutorial;
        TutorialScenes.visitedCrafting = data.craftingTutorial;

        TutorialScenes.visitedInventory = data.inventoryTutorial;
        TutorialScenes.visitedShop = data.shopTutorial;
        TutorialScenes.visitedPlayerstats = data.playerstatsTutorial;
    }
}
