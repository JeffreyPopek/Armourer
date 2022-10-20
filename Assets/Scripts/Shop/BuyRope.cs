using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyRope : MonoBehaviour
{
    [SerializeField] private GameObject notEnough;
    public int buyRopeButton;
    // Start is called before the first frame update
    void Start()
    {
        notEnough.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnMouseOver()
    {
        if (buyRopeButton == 1)
        {
            if (bag.gold < 1)
            {
                notEnough.SetActive(true);
            }
        }
        else if (buyRopeButton == 2)
        {
            if (bag.gold < 5)
            {
                notEnough.SetActive(true);
            }
        }
        else if (buyRopeButton == 3)
        {
            if (bag.gold < 10)
            {
                notEnough.SetActive(true);
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            if(buyRopeButton == 1)
            {
                bag.rope++;
                bag.gold--;
            }
            else if(buyRopeButton == 2)
            {
                bag.rope += 5;
                bag.gold -= 5;
            }
            else if(buyRopeButton == 3)
            {
                bag.rope += 10;
                bag.gold -= 10;
            }
        }
    }

    private void OnMouseExit()
    {
        notEnough.SetActive(false);
    }
}
