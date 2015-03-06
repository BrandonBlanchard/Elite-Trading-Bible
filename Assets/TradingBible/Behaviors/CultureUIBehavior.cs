using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Assets.TradingBible.Models;

public class CultureUIBehavior : MonoBehaviour 
{
    public CultureModel Model { get; private set; }

    public string Name { get; private set; }

    public Text Header;

    public GameObject BuyContainer;

    public GameObject SellContainer;

    public void Init(CultureModel model)
    {
        Model = model;
        UpdateName(model.Name);
    }

	public void Start () 
    {
	
	}
	
    public void Update () 
    {
	
	}

    public void UpdateName (string name)
    {
        Name = name;
        Header.text = name;
    }
}
