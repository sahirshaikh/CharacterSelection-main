using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;

    [Serializable]
    public class Tank
    {
        public TankType tankType;
        public Material Color;
        public float movementSpeed;
        public float rotationSpeed;
    }

    public List<Tank> tankList;

    void Start()
    {
       

        
    }

    public void CreateTank(TankType tankType)
    {

        if (tankType == TankType.BlueTank)
        {
            TankModel tankModel= new TankModel(tankList[1].movementSpeed,tankList[1].rotationSpeed,tankList[1].tankType,tankList[1].Color);
            TankController tankController= new TankController(tankModel,tankView);
        }
        else if (tankType == TankType.GreenTank)
        {
            TankModel tankModel= new TankModel(tankList[0].movementSpeed,tankList[0].rotationSpeed,tankList[0].tankType,tankList[0].Color);
            TankController tankController= new TankController(tankModel,tankView);
        }

        else if (tankType == TankType.RedTank)
        {
            TankModel tankModel= new TankModel(tankList[2].movementSpeed,tankList[2].rotationSpeed,tankList[2].tankType,tankList[2].Color);
            TankController tankController= new TankController(tankModel,tankView);
        }
  



    }

}
