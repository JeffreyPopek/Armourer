using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getwinbutton : MonoBehaviour
{
    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            bag.completed = true;
        }
        else if(Input.GetMouseButtonDown(1))
        {
            bag.completed = false;
        }
    }
}
