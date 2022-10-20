using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodCounter
{
    public static int wood = 0;
    public static int axeLevel = 1;

    //xp bar
    //public static int woodCuttingLevel = 1;
    //public static int woodCuttingXP = 0;
    //public static int xpNeeded = 1000;

}
public class WoodCutting : MonoBehaviour
{
    [SerializeField] private TMP_Text woodAmount;
    [SerializeField] private TMP_Text cuttingRate;
    //[SerializeField] private TMP_Text woodCuttingXP;
    //[SerializeField] private TMP_Text xpProgress;
    //[SerializeField] private TMP_Text skillLevel;


    private void Start()
    {
        StartCoroutine(autoCut());

        woodAmount.text = WoodCounter.wood.ToString();
        cuttingRate.text = WoodCounter.axeLevel.ToString();

       ////xp bar
       //woodCuttingXP.text = WoodCounter.woodCuttingXP.ToString();
       //xpProgress.text = WoodCounter.xpNeeded.ToString();
       ////level
       //skillLevel.text = WoodCounter.woodCuttingLevel.ToString();


    }

    private void Update()
    {
        woodAmount.text = WoodCounter.wood.ToString();
        cuttingRate.text = WoodCounter.axeLevel.ToString();

        //xp bar
        //woodCuttingXP.text = WoodCounter.woodCuttingXP.ToString();
        //xpProgress.text = WoodCounter.xpNeeded.ToString();

        //level
        //skillLevel.text = WoodCounter.woodCuttingLevel.ToString();

        //check if you have enough cp to level up woodcutting level
        //if (WoodCounter.woodCuttingXP == WoodCounter.xpNeeded || WoodCounter.woodCuttingXP > WoodCounter.xpNeeded)
        //{
        //    levelUp();
        //}
    }

    //public void levelUp()
    //{
    //    WoodCounter.xpNeeded += 1000;
    //    WoodCounter.woodCuttingLevel++;
    //}

    IEnumerator autoCut()
    {
        bool started = true;
        while(started == true)
        {
            yield return new WaitForSeconds(1f);
            //Debug.Log("works");
            cutWood();
        }
    }

    public void cutWood()
    {
        WoodCounter.wood += WoodCounter.axeLevel;
        PlayerLevels.WoodcuttingXPtemp++;
        PlayerLevels.WoodcuttingXP++;
    }


   
}
