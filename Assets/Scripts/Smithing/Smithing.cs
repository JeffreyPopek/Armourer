using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Smithing : MonoBehaviour
{
    [SerializeField] private TMP_Text oreAmount;
    [SerializeField] private TMP_Text barAmount;
    void Start()
    {
        oreAmount.text = OreCounter.ore.ToString();
        barAmount.text = bag.bars.ToString();
    }

    void Update()
    {
        oreAmount.text = OreCounter.ore.ToString();
        barAmount.text = bag.bars.ToString();
    }
}
