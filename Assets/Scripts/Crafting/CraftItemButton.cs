using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftItemButton : MonoBehaviour
{
    public int itemType;

    //I -> INPUT, O -> OUTPUT
    [SerializeField] private GameObject craftingArrow;
    [SerializeField] private GameObject craftingPlus;

    [SerializeField] private GameObject woodI;
    [SerializeField] private GameObject barsI;
    [SerializeField] private GameObject swordBladeI;
    [SerializeField] private GameObject swordHiltI;
    [SerializeField] private GameObject bowstringI;
    [SerializeField] private GameObject arrowTipI;
    [SerializeField] private GameObject arrowShaftI;
    [SerializeField] private GameObject ropeI;

    [SerializeField] private GameObject swordO;
    [SerializeField] private GameObject shieldO;
    [SerializeField] private GameObject bowO;
    [SerializeField] private GameObject arrowO;
    [SerializeField] private GameObject armorO;

    [SerializeField] private GameObject swordBladeO;
    [SerializeField] private GameObject swordHiltO;
    [SerializeField] private GameObject bowstringO;
    [SerializeField] private GameObject arrowShaftO;
    [SerializeField] private GameObject arrowTipO;   

    [SerializeField] private GameObject woodI2;
    [SerializeField] private GameObject barsI2;
    [SerializeField] private GameObject ropeI2;

    void Start()
    {
        //CRAFTING UI
        craftingArrow.SetActive(false);
        craftingPlus.SetActive(false);

        //WEAPON INPUT
        woodI.SetActive(false);
        barsI.SetActive(false);
        swordBladeI.SetActive(false);
        swordHiltI.SetActive(false);
        bowstringI.SetActive(false);
        arrowTipI.SetActive(false);
        arrowShaftI.SetActive(false);
        ropeI.SetActive(false);

        //WEAPON OUTPUT
        swordO.SetActive(false);
        shieldO.SetActive(false);
        bowO.SetActive(false);
        arrowO.SetActive(false);
        armorO.SetActive(false);

        //MATERIAL OUTPUT
        swordBladeO.SetActive(false);
        swordHiltO.SetActive(false);
        bowstringO.SetActive(false);
        arrowShaftO.SetActive(false);
        arrowTipO.SetActive(false);

        //MATERIAL INPUT
        woodI2.SetActive(false);
        barsI2.SetActive(false);
        ropeI2.SetActive(false);
    }

    private void OnMouseEnter()
    {
        if (itemType == 1)
        {
            //SWORD
            craftingArrow.SetActive(true);
            craftingPlus.SetActive(true);

            swordHiltI.SetActive(true);
            swordBladeI.SetActive(true);

            swordO.SetActive(true);
        }
        else if(itemType == 2)
        {
            //SHIELD
            craftingArrow.SetActive(true);
            craftingPlus.SetActive(true);

            ropeI.SetActive(true);
            barsI.SetActive(true);

            shieldO.SetActive(true);
        }
        else if (itemType == 3)
        {
            //BOW
            craftingArrow.SetActive(true);
            craftingPlus.SetActive(true);

            bowstringI.SetActive(true);
            woodI.SetActive(true);

            bowO.SetActive(true);
        }
        else if (itemType == 4)
        {
            //ARROW
            craftingArrow.SetActive(true);
            craftingPlus.SetActive(true);

            arrowShaftI.SetActive(true);
            arrowTipI.SetActive(true);

            arrowO.SetActive(true);
        }
        else if (itemType == 5)
        {
            //ARMOR
            craftingArrow.SetActive(true);

            barsI.SetActive(true);

            armorO.SetActive(true);
        }
        else if (itemType == 6)
        {
            //SWORD BLADE
            craftingArrow.SetActive(true);

            barsI2.SetActive(true);

            swordBladeO.SetActive(true);
        }
        else if (itemType == 7)
        {
            //SWORD HILT
            craftingArrow.SetActive(true);

            woodI2.SetActive(true);

            swordHiltO.SetActive(true);
        }
        else if (itemType == 8)
        {
            //BOWSTRING
            craftingArrow.SetActive(true);

            ropeI2.SetActive(true);

            bowstringO.SetActive(true);
        }
        else if (itemType == 9)
        {
            //ARROW SHAFT
            craftingArrow.SetActive(true);

            woodI2.SetActive(true);

            arrowShaftO.SetActive(true);
        }
        else if (itemType == 10)
        {
            //ARROW TIP
            craftingArrow.SetActive(true);

            barsI2.SetActive(true);

            arrowTipO.SetActive(true);
        }

    }

    private void OnMouseExit()
    {
        //CRAFTING UI
        craftingArrow.SetActive(false);
        craftingPlus.SetActive(false);

        //WEAPON INPUT
        woodI.SetActive(false);
        barsI.SetActive(false);
        swordBladeI.SetActive(false);
        swordHiltI.SetActive(false);
        bowstringI.SetActive(false);
        arrowTipI.SetActive(false);
        arrowShaftI.SetActive(false);
        ropeI.SetActive(false);

        //WEAPON OUTPUT
        swordO.SetActive(false);
        shieldO.SetActive(false);
        bowO.SetActive(false);
        arrowO.SetActive(false);
        armorO.SetActive(false);

        //MATERIAL OUTPUT
        swordBladeO.SetActive(false);
        swordHiltO.SetActive(false);
        bowstringO.SetActive(false);
        arrowShaftO.SetActive(false);
        arrowTipO.SetActive(false);

        //MATERIAL INPUT
        woodI2.SetActive(false);
        barsI2.SetActive(false);
        ropeI2.SetActive(false);
    }
}
