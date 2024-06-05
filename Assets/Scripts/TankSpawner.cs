using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject greenTank;

    void Start()
    {
        Instantiate(greenTank,transform.position, Quaternion.identity);
        
    }

}
