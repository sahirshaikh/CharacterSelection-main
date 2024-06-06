using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;
    public GameObject LobbyUI;

    public void BlueTankSelected()
    {
        Debug.Log("Blue Selected");
        tankSpawner.CreateTank(TankType.BlueTank);
        LobbyUI.SetActive(false);
        
    }

    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankType.GreenTank);
        LobbyUI.SetActive(false);
    }

    public void RedTankSelected()
    {
       tankSpawner.CreateTank(TankType.RedTank); 
        LobbyUI.SetActive(false);
    }

}
