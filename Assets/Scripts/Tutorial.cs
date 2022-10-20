using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TutorialScenes
{
    /*
    0 - lore scene
    1 - woodcutting
    2 - mining 
    3 - smelting
    4 - crafting
    5 - inventory
    6 - shop
    7 - player stats
    */
    public static bool visitedLore = false;

    public static bool visitedWoodbutting = false;
    public static bool visitedMining = false;
    public static bool visitedSmelting = false;
    public static bool visitedCrafting = false;

    public static bool visitedInventory = false;
    public static bool visitedShop = false;
    public static bool visitedPlayerstats = false;
}

public class Tutorial : MonoBehaviour
{
    public int scene;
    [SerializeField] private GameObject tutoialBox;
    //disables text in the canvas when tutorial box is not active
    [SerializeField] private GameObject tutorialTextHolder;

    private void checkScene(int num)
    {
        if (num == 0)
        {
            if (!TutorialScenes.visitedLore)
            {
                boxesOn();
            }
            else
            {
                boxesOff();
            }
        }
        else if (num == 1)
        {
            if (!TutorialScenes.visitedWoodbutting)
            {
                boxesOn();
            }
            else
            {
                boxesOff();
            }
        }
        else if (num == 2)
        {
            if (!TutorialScenes.visitedMining)
            {
                boxesOn();
            }
            else
            {
                boxesOff();
            }
        }
        else if (num == 3)
        {
            if (!TutorialScenes.visitedSmelting)
            {
                boxesOn();
            }
            else
            {
                boxesOff();
            }
        }
        else if (num == 4)
        {
            if (!TutorialScenes.visitedCrafting)
            {
                boxesOn();
            }
            else
            {
                boxesOff();
            }
        }
        else if (num == 5)
        {
            if (!TutorialScenes.visitedInventory)
            {
                boxesOn();
            }
            else
            {
                boxesOff();
            }
        }
        else if (num == 6)
        {
            if (!TutorialScenes.visitedShop)
            {
                boxesOn();
            }
            else
            {
                boxesOff();
            }
        }
        else if (num == 7)
        {
            if (!TutorialScenes.visitedPlayerstats)
            {
                boxesOn();
            }
            else
            {
                boxesOff();
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        checkScene(scene);
    }

    private void OnMouseDown()
    {
        boxesOff();

        if(scene == 0)
        {
            TutorialScenes.visitedLore = true;
            SceneManager.LoadScene(4);

        }
        else if(scene == 1)
        {
            TutorialScenes.visitedWoodbutting = true;
        }
        else if (scene == 2)
        {
            TutorialScenes.visitedMining = true;
        }
        else if (scene == 3)
        {
            TutorialScenes.visitedSmelting = true;
        }
        else if (scene == 4)
        {
            TutorialScenes.visitedCrafting = true;
        }
        else if (scene == 5)
        {
            TutorialScenes.visitedInventory = true;
        }
        else if (scene == 6)
        {
            TutorialScenes.visitedShop = true;
        }
        else if (scene == 7)
        {
            TutorialScenes.visitedPlayerstats = true;
        }

    }

    private void boxesOn()
    {
        tutoialBox.SetActive(true);
        tutorialTextHolder.SetActive(true);
    }

    private void boxesOff()
    {
        tutoialBox.SetActive(false);
        tutorialTextHolder.SetActive(false);
    }
}
