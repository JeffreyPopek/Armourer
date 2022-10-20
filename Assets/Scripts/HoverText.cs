using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HoverText : MonoBehaviour
{
    [SerializeField] private GameObject text;

    private bool hovering = false;
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(hovering == false)
        {
            text.SetActive(false);
        }
    }

    public void OnMouseOver()
    {
        text.SetActive(true);
        hovering = true;
    }

    public void OnMouseExit()
    {
        text.SetActive(false);
        hovering = false;
    }
}
