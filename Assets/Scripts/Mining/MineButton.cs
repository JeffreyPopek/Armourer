using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineButton : MonoBehaviour
{ 
    private void OnMouseDown()
    {
        mineOre();
    }

    public void mineOre()
    {
        OreCounter.ore += OreCounter.pickaxeLevel;
        PlayerLevels.MiningXPtemp++;
        PlayerLevels.MiningXP++;
    }
}
