using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    public int sectorID = 0;
    public GameObject[] mapSectors;

    //The different selectable Space Sectors
    public GameObject govSector;
    public GameObject bytoSector;
    public GameObject sevenSector;
    public GameObject erwSector;

    public Vector2 direction;

    private void Awake()
    {
        govSector = GameObject.Find("GovernmentSpace");
        bytoSector = GameObject.Find("BytoSpace");
        sevenSector = GameObject.Find("SevenSpace");
        erwSector = GameObject.Find("ERWSpace");
        SwitchToSection(sectorID);
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (Input.GetKeyDown(KeyCode.Mouse0) && hit.collider != null)
        {
            //Selecting Government Space
            if(hit.collider.gameObject.name == "GovernmentSpace")
            {
                SwitchToSection(0);
                Debug.Log("Government Space Selected");
            }
            //Selecting Byto Corporate Space
            if(hit.collider.gameObject.name == "BytoSpace")
            {
                if (PlayerVariables.bytoPass == 0)
                {
                    Debug.Log("You Do Not Have The Required Pass");
                }
                else if (PlayerVariables.bytoPass != 0)
                {
                    SwitchToSection(1);
                    Debug.Log("Byto Pass Found");
                }
            }
            //Selecting Seven Corporate Space
            if (hit.collider.gameObject.name == "SevenSpace")
            {
                if (PlayerVariables.sevenPass == 0)
                {
                    Debug.Log("You Do Not Have The Required Pass");
                }
                else if (PlayerVariables.sevenPass != 0)
                {
                    SwitchToSection(2);
                    Debug.Log("Seven Pass Found");
                }
            }
            //Selecting ERW Corporate Space
            if (hit.collider.gameObject.name == "ERWSpace")
            {
                if (PlayerVariables.erwPass == 0)
                {
                    Debug.Log("You Do Not Have The Required Pass");
                }
                else if (PlayerVariables.erwPass != 0)
                {
                    SwitchToSection(3);
                    Debug.Log("ERW Pass Found");
                }
            }
        }
    }

    public void SwitchToSection(int menuID)
    {
        foreach(GameObject sector in mapSectors)
        {
            sector.gameObject.SetActive(false);
        }

        switch (sectorID)
        {
            case 0:
                govSector.gameObject.SetActive(true);
                break;
            case 1:
                bytoSector.gameObject.SetActive(true);
                break;
            case 2:
                sevenSector.gameObject.SetActive(true);
                break;
            case 3:
                erwSector.gameObject.SetActive(true);
                break;
        }
    }
}
