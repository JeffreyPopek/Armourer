using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmitButton : MonoBehaviour
{
    //SUBMIT WEAPONS 
    [SerializeField] private GameObject submitButton;
    [SerializeField] private GameObject submitButtonText;
    [SerializeField] private GameObject submitText;
    [SerializeField] private GameObject notEnoughText;

    private int swordsNeeded = 30;
    private int shieldsNeeded = 30;
    private int bowsNeeded = 20;
    private int arrowsNeeded = 100;
    private int armorNeeded = 30;

    private bool hasWeapons = false;


    // Start is called before the first frame update
    void Start()
    {
        if(bag.completed == true)
        {
            submitButton.SetActive(false);
            submitButtonText.SetActive(false);
        }
        submitText.SetActive(false);
        notEnoughText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(bag.sword >= swordsNeeded && bag.shield >= shieldsNeeded && bag.bow >= bowsNeeded && bag.arrow >= arrowsNeeded && bag.arrow >= armorNeeded)
        {
            notEnoughText.SetActive(false);
            hasWeapons = true;
        }
        else
        {
            hasWeapons = false;
        }
    }

    private void OnMouseOver()
    {
        submitText.SetActive(true);
        if (!hasWeapons)
        {
            notEnoughText.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(hasWeapons)
            {
                bag.sword -= 30;
                bag.shield -= 30;
                bag.bow -= 20; 
                bag.arrow -= 100;
                bag.armor -= 30;

                WinGame();
            }
        }
    }

    private void OnMouseExit()
    {
        submitText.SetActive(false);
        notEnoughText.SetActive(false);
    }

    public void WinGame()
    {
        bag.completed = true;
        SceneManager.LoadScene(8);
        getRich();
    }

    private void getRich()
    {
        bag.gold += 1000000;
    }
}
