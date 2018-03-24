using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMapInfo : MonoBehaviour {

    public Text mc_PlayerMoney;
    public Text mc_ShipFuel;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update ()
    {
        mc_PlayerMoney.text = PlayerVariables.playerMoney.ToString();
        mc_ShipFuel.text = PlayerVariables.shipFuel.ToString();
	}
}
