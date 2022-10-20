using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemHover : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    //SHOWS IF SMELTING LEVEL IS NOT HIGH ENOUGH
    [SerializeField] private GameObject levelTooLow;
    [SerializeField] private TMP_Text levelReq;

    //SHOWS COST OF EACH ITEM
    [SerializeField] private GameObject costHolder;
    [SerializeField] private TMP_Text cost1;
    [SerializeField] private TMP_Text cost2;

    [SerializeField] private GameObject costTextHolder;
    [SerializeField] private TMP_Text owned1;
    [SerializeField] private TMP_Text owned2;
    [SerializeField] private TMP_Text productOwned;
    [SerializeField] private GameObject notEnoughText;



    public int ItemType;

    void Start()
    {
        text.text = "";
        levelTooLow.SetActive(false);
        costHolder.SetActive(false);
        costTextHolder.SetActive(false);
        notEnoughText.SetActive(false);
    }


    public void OnMouseOver()
    {
        if (ItemType == 1)
        {
            //SWORD
            text.text = "Sword";

            costHolder.SetActive(true);
            costTextHolder.SetActive(true);
            owned1.text = bag.swordHilt.ToString();
            owned2.text = bag.swordBlade.ToString();
            productOwned.text = bag.sword.ToString();

            int itemLevelReq = 2;

            //COST FOR EACH OF THE COST SLOTS
            int cost_1 = 1;
            int cost_2 = 1;
            bool hasMaterials = false;
            cost1.text = cost_1.ToString();
            cost2.text = cost_2.ToString();

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY DO THEN THE BOOL FOR LATER IS CHECK AS TRUE
            if (bag.swordHilt < cost_1 || bag.swordBlade < cost_2)
            {
                notEnoughText.SetActive(true);
                hasMaterials = false;
            }
            else
            {
                hasMaterials = true;
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT, IF NOT THEN THE NOT HIGH ENOUGH LEVEL TEXT SHOWS UP
            if (PlayerLevels.SmeltingLevel < itemLevelReq)
            {
                levelTooLow.SetActive(true);
                levelReq.text = itemLevelReq.ToString();
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT AND HAS THE MATERIALS IN THEIR INVENTORY, IF THEY HAVE BOTH THEN THEY GET ONE OF THE ITEM
            if (Input.GetMouseButtonDown(0))
            {           
                if(PlayerLevels.SmeltingLevel >= itemLevelReq && hasMaterials)
                {
                    makeItem();
                }
            }
        }

        if (ItemType == 2)
        {
            //SHIELD
            text.text = "Shield";

            costHolder.SetActive(true);
            costTextHolder.SetActive(true);
            owned1.text = bag.rope.ToString();
            owned2.text = bag.bars.ToString();
            productOwned.text = bag.shield.ToString();

            int itemLevelReq = 3;
            //COST FOR EACH OF THE COST SLOTS
            int cost_1 = 5;
            int cost_2 = 10;
            bool hasMaterials = false;
            cost1.text = cost_1.ToString();
            cost2.text = cost_2.ToString();

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY DO THEN THE BOOL FOR LATER IS CHECK AS TRUE
            if (bag.rope < cost_1 || bag.bars < cost_2)
            {
                notEnoughText.SetActive(true);
                hasMaterials = false;
            }
            else
            {
                hasMaterials = true;
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT, IF NOT THEN THE NOT HIGH ENOUGH LEVEL TEXT SHOWS UP
            if (PlayerLevels.SmeltingLevel < itemLevelReq)
            {
                levelTooLow.SetActive(true);
                levelReq.text = itemLevelReq.ToString();
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT AND HAS THE MATERIALS IN THEIR INVENTORY, IF THEY HAVE BOTH THEN THEY GET ONE OF THE ITEM
            if (Input.GetMouseButtonDown(0))
            {
                if (PlayerLevels.SmeltingLevel >= itemLevelReq && hasMaterials)
                {
                    makeItem();
                }
            }
        }

        if (ItemType == 3)
        {
            //BOW
            text.text = "Bow";

            costHolder.SetActive(true);
            costTextHolder.SetActive(true);
            owned1.text = bag.bowstring.ToString();
            owned2.text = WoodCounter.wood.ToString();
            productOwned.text = bag.bow.ToString();

            //COST FOR EACH OF THE COST SLOTS
            int cost_1 = 1;
            int cost_2 = 10;
            bool hasMaterials = false;
            cost1.text = cost_1.ToString();
            cost2.text = cost_2.ToString();

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY DO THEN THE BOOL FOR LATER IS CHECK AS TRUE
            if (bag.bowstring < cost_1 || WoodCounter.wood < cost_2)
            {
                notEnoughText.SetActive(true);
                hasMaterials = false;
            }
            else
            {
                hasMaterials = true;
            }



            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY HAVE BOTH THEN THEY GET ONE OF THE ITEM
            if (Input.GetMouseButtonDown(0))
            {
                if (hasMaterials)
                {
                    makeItem();
                }
            }
        }

        if (ItemType == 4)
        {
            //ARROW
            text.text = "Arrow";

            costHolder.SetActive(true);
            costTextHolder.SetActive(true);
            owned1.text = bag.arrowtip.ToString();
            owned2.text = bag.arrowshaft.ToString();
            productOwned.text = bag.arrow.ToString();

            int itemLevelReq = 5;

            //COST FOR EACH OF THE COST SLOTS
            int cost_1 = 1;
            int cost_2 = 1;
            bool hasMaterials = false;
            cost1.text = cost_1.ToString();
            cost2.text = cost_2.ToString();

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY DO THEN THE BOOL FOR LATER IS CHECK AS TRUE
            if (bag.arrowtip < cost_1 || bag.arrowshaft < cost_2)
            {
                notEnoughText.SetActive(true);
                hasMaterials = false;
            }
            else
            {
                hasMaterials = true;
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT, IF NOT THEN THE NOT HIGH ENOUGH LEVEL TEXT SHOWS UP
            if (PlayerLevels.SmeltingLevel < itemLevelReq)
            {
                levelTooLow.SetActive(true);
                levelReq.text = itemLevelReq.ToString();
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT AND HAS THE MATERIALS IN THEIR INVENTORY, IF THEY HAVE BOTH THEN THEY GET ONE OF THE ITEM
            if (Input.GetMouseButtonDown(0))
            {
                if (PlayerLevels.SmeltingLevel >= itemLevelReq && hasMaterials)
                {
                    makeItem();
                }
            }
        }

        if (ItemType == 5)
        {
            //ARMOR
            text.text = "Armor";

            costHolder.SetActive(true);
            costTextHolder.SetActive(true);
            owned1.text = "";
            owned2.text = bag.bars.ToString();
            productOwned.text = bag.armor.ToString();

            int itemLevelReq = 10;

            //COST FOR EACH OF THE COST SLOTS
            int cost_2 = 20;
            bool hasMaterials = false;
            cost1.text = "";
            cost2.text = cost_2.ToString();

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY DO THEN THE BOOL FOR LATER IS CHECK AS TRUE
            if (bag.bars < cost_2)
            {
                notEnoughText.SetActive(true);
                hasMaterials = false;
            }
            else
            {
                hasMaterials = true;
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT, IF NOT THEN THE NOT HIGH ENOUGH LEVEL TEXT SHOWS UP
            if (PlayerLevels.SmeltingLevel < itemLevelReq)
            {
                levelTooLow.SetActive(true);
                levelReq.text = itemLevelReq.ToString();
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT AND HAS THE MATERIALS IN THEIR INVENTORY, IF THEY HAVE BOTH THEN THEY GET ONE OF THE ITEM
            if (Input.GetMouseButtonDown(0))
            {
                if (PlayerLevels.SmeltingLevel >= itemLevelReq && hasMaterials)
                {
                    makeItem();
                }
            }
    }

        if (ItemType == 6)
        {
            //SWORD BLADE
            text.text = "Sword Blade";

            costHolder.SetActive(true);
            costTextHolder.SetActive(true);
            owned1.text = "";
            owned2.text = bag.bars.ToString();
            productOwned.text = bag.swordBlade.ToString();

            int itemLevelReq = 2;

            //COST FOR EACH OF THE COST SLOTS
            int cost_2 = 6;
            bool hasMaterials = false;
            cost1.text = "";
            cost2.text = cost_2.ToString();

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY DO THEN THE BOOL FOR LATER IS CHECK AS TRUE
            if (bag.bars < cost_2)
            {
                notEnoughText.SetActive(true);
                hasMaterials = false;
            }
            else
            {
                hasMaterials = true;
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT, IF NOT THEN THE NOT HIGH ENOUGH LEVEL TEXT SHOWS UP
            if (PlayerLevels.SmeltingLevel < itemLevelReq)
            {
                levelTooLow.SetActive(true);
                levelReq.text = itemLevelReq.ToString();
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT AND HAS THE MATERIALS IN THEIR INVENTORY, IF THEY HAVE BOTH THEN THEY GET ONE OF THE ITEM
            if (Input.GetMouseButtonDown(0))
            {
                if (PlayerLevels.SmeltingLevel >= itemLevelReq && hasMaterials)
                {
                    makeItem();
                }
            }
    }

        if (ItemType == 7)
        {
            //SWORD HILT
            text.text = "Sword Hilt";

            costHolder.SetActive(true);
            costTextHolder.SetActive(true);
            owned1.text = "";
            owned2.text = WoodCounter.wood.ToString();
            productOwned.text = bag.swordHilt.ToString();

            //COST FOR EACH OF THE COST SLOTS
            int cost_2 = 5;
            bool hasMaterials = false;
            cost1.text = "";
            cost2.text = cost_2.ToString();

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY DO THEN THE BOOL FOR LATER IS CHECK AS TRUE
            if (WoodCounter.wood < cost_2)
            {
                notEnoughText.SetActive(true);
                hasMaterials = false;
            }
            else
            {
                hasMaterials = true;
            }

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY
            if (Input.GetMouseButtonDown(0))
            {
                if (hasMaterials)
                {
                    makeItem();
                }
            }
        }

        if (ItemType == 8)
        {
            //BOWSTRING
            text.text = "Bowstring";

            costHolder.SetActive(true);
            costTextHolder.SetActive(true);
            owned1.text = "";
            owned2.text = bag.rope.ToString();
            productOwned.text = bag.bowstring.ToString();


            //COST FOR EACH OF THE COST SLOTS
            int cost_2 = 5;
            bool hasMaterials = false;
            cost1.text = "";
            cost2.text = cost_2.ToString();

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY DO THEN THE BOOL FOR LATER IS CHECK AS TRUE
            if (bag.rope < cost_2)
            {
                notEnoughText.SetActive(true);
                hasMaterials = false;
            }
            else
            {
                hasMaterials = true;
            }

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY
            if (Input.GetMouseButtonDown(0))
            {
                if (hasMaterials)
                {
                    makeItem();
                }
            }
        }

        if (ItemType == 9)
        {
            //ARROW SHAFT
            text.text = "Arrow Shaft";

            costHolder.SetActive(true);
            costTextHolder.SetActive(true);
            owned1.text = "";
            owned2.text = WoodCounter.wood.ToString();
            productOwned.text = bag.arrowshaft.ToString();

            //COST FOR EACH OF THE COST SLOTS
            int cost_2 = 1;
            bool hasMaterials = false;
            cost1.text = "";
            cost2.text = cost_2.ToString();

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY DO THEN THE BOOL FOR LATER IS CHECK AS TRUE
            if (WoodCounter.wood < cost_2)
            {
                notEnoughText.SetActive(true);
                hasMaterials = false;
            }
            else
            {
                hasMaterials = true;
            }

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY HAVE IT THEN THEY GET ONE OF THE ITEM
            if (Input.GetMouseButtonDown(0))
            {
                if (hasMaterials)
                {
                    makeItem();
                }
            }
        }

        if (ItemType == 10)
        {
            //ARROW TIP
            text.text = "Arrow Tip";

            costHolder.SetActive(true);
            costTextHolder.SetActive(true);
            owned1.text = "";
            owned2.text = bag.bars.ToString();
            productOwned.text = bag.arrowtip.ToString();

            int itemLevelReq = 5;

            //COST FOR EACH OF THE COST SLOTS
            int cost_2 = 4;
            bool hasMaterials = false;
            cost1.text = "";
            cost2.text = cost_2.ToString();

            //CHECKS IF PLAYER HAS THE MATERIALS IN THEIR INVENTORY, IF THEY DO THEN THE BOOL FOR LATER IS CHECK AS TRUE
            if (bag.bars < cost_2)
            {
                notEnoughText.SetActive(true);
                hasMaterials = false;
            }
            else
            {
                hasMaterials = true;
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT, IF NOT THEN THE NOT HIGH ENOUGH LEVEL TEXT SHOWS UP
            if (PlayerLevels.SmeltingLevel < itemLevelReq)
            {
                levelTooLow.SetActive(true);
                levelReq.text = itemLevelReq.ToString();
            }

            //CHECKS IF PLAYER MEETS THE LEVEL REQUIREMENT AND HAS THE MATERIALS IN THEIR INVENTORY, IF THEY HAVE BOTH THEN THEY GET ONE OF THE ITEM
            if (Input.GetMouseButtonDown(0))
            {
                if (PlayerLevels.SmeltingLevel >= itemLevelReq && hasMaterials)
                {
                    makeItem();
                }
            }
        }
    }

    public void OnMouseExit()
    {
        text.text = "";
        levelTooLow.SetActive(false);
        costHolder.SetActive(false);
        costTextHolder.SetActive(false);
        notEnoughText.SetActive(false);
    }

    public void makeItem()
    {
        
        if (ItemType == 1)
        {
            //SWORD
            bag.sword++;
            bag.swordHilt--;
            bag.swordBlade--;
        }
        if (ItemType == 2)
        {
            //SHIELD
            bag.shield++;
            bag.rope -= 5;
            bag.bars -= 10;
        }
        if (ItemType == 3)
        {
            //BOW
            bag.bow++;
            WoodCounter.wood -= 10;
            bag.bowstring--;
        }
        if (ItemType == 4)
        {
            //ARROW
            bag.arrow++;
            bag.arrowshaft--;
            bag.arrowtip--;
        }
        if (ItemType == 5)
        {
            //ARMOR
            bag.armor++;
            bag.bars -= 20;
        }
        if (ItemType == 6)
        {
            //SWORD BLADE
            bag.swordBlade++;
            bag.bars -= 6;
        }
        if (ItemType == 7)
        {
            //SWORD HILT
            bag.swordHilt++;
            WoodCounter.wood -= 5;
        }
        if (ItemType == 8)
        {
            //BOWSTRING
            bag.bowstring++;
            bag.rope -= 5;
        }
        if (ItemType == 9)
        {
            //ARROW SHAFT
            bag.arrowshaft++;
            WoodCounter.wood--;
        }
        if (ItemType == 10)
        {
            //ARROW TIP
            bag.arrowtip++;
            bag.bars--;
        }
        PlayerLevels.CraftingXP += 10;
        PlayerLevels.CraftingXPtemp += 10;
    }

}
