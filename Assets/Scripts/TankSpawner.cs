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
       
        CreateTank();
        
    }

    public void CreateTank()
    {
        TankModel tankModel= new TankModel(tankList[2].movementSpeed,tankList[2].rotationSpeed,tankList[2].tankType,tankList[2].Color);

        TankController tankController= new TankController(tankModel,tankView);

    }

}
