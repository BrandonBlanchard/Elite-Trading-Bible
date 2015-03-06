using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using Assets.TradingBible.Models;

public class CommodityUIBehavior : MonoBehaviour 
{

    public CommodityModel Model;

    public GameObject GraphicContainer;

    public Text TextObject;

    public string Name { get; private set; }

    public void Init(CommodityModel type)
    {
        Model = type;
        UpdateName(type.Name);
        // Update Icon will go here.
    }

	public void Start () 
    {
	    
	}
	
	public void Update () 
    {
	    
	}

    public void UpdateName(string newName)
    {
        Name = newName;
        // String animation could go here. 
        TextObject.text = Name;
    }
}
