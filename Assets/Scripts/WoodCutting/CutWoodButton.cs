using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutWoodButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        cutWood();
    }

    public void cutWood()
    {
        WoodCounter.wood += WoodCounter.axeLevel;
        PlayerLevels.WoodcuttingXPtemp++;
        PlayerLevels.WoodcuttingXP++;
    }
}
