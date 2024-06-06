using UnityEngine;

public class TankModel 
{
    [SerializeField] private TankController tankController;

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

}
