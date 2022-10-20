using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingMenu : MonoBehaviour
{

    //TEXT TO TELL PLAYER THEY CAN ROTATE CRAFTING 
    [SerializeField] private GameObject infotext;

    //FIRST SET OF ITEMS TO APPEAR
    [SerializeField] private GameObject button1; //SWORD
    [SerializeField] private GameObject button2; //SHIELD
    [SerializeField] private GameObject button3; //BOW
    [SerializeField] private GameObject button4; //ARROW
    [SerializeField] private GameObject button5; //ARMOR


    //SECOND SET OF ITEMS TO APPEAR
    [SerializeField] private GameObject button6; //SWORD BLADE
    [SerializeField] private GameObject button7; //SWORD HILT
    [SerializeField] private GameObject button8; //BOWSTRING
    [SerializeField] private GameObject button9; //ARROW SHAFT
    [SerializeField] private GameObject button10; //ARROW TIP
    private bool firstclick = true;
    private bool secondclick = false;


    void Start()
    {
        //DISABLE INFO TEXT
        infotext.SetActive(false);

        //SET 1
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
        button5.SetActive(true);

        //SET 2
        button6.SetActive(false);
        button7.SetActive(false);
        button8.SetActive(false);
        button9.SetActive(false);
        button10.SetActive(false);
    }

    public void OnMouseDown()
    {
        if(firstclick == true)
        {
            firstclick = false;
            secondclick = true;

            //SET 1
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
            button5.SetActive(false);

            //SET 2
            button6.SetActive(true);
            button7.SetActive(true);
            button8.SetActive(true);
            button9.SetActive(true);
            button10.SetActive(true);
        }
        else if(secondclick == true)
        {
            secondclick = false;
            firstclick = true;

            //SET 1
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            button5.SetActive(true);

            //SET 2
            button6.SetActive(false);
            button7.SetActive(false);
            button8.SetActive(false);
            button9.SetActive(false);
            button10.SetActive(false);
        }
    }

    private void OnMouseEnter()
    {
        infotext.SetActive(true);
    }

    private void OnMouseExit()
    {
        infotext.SetActive(false);
    }
}
