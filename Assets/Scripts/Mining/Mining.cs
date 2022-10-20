using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OreCounter
{
    public static int ore = 0;
    public static int miningRate = 1;
    public static int pickaxeLevel = 1;
}
public class Mining : MonoBehaviour
{
    [SerializeField] private TMP_Text oreAmount;
    [SerializeField] private TMP_Text miningRate;


    private void Start()
    {
        StartCoroutine(autoMine());

        oreAmount.text = OreCounter.ore.ToString();
        miningRate.text = OreCounter.pickaxeLevel.ToString();
    }

    private void Update()
    {
        oreAmount.text = OreCounter.ore.ToString();
        miningRate.text = OreCounter.pickaxeLevel.ToString();
    }


    IEnumerator autoMine()
    {
        bool started = true;
        while (started == true)
        {
            yield return new WaitForSeconds(1f);
            mineOre();
        }
    }

    public void mineOre()
    {
        OreCounter.ore += OreCounter.pickaxeLevel;
        PlayerLevels.MiningXPtemp++;
        PlayerLevels.MiningXP++;
    }



}
