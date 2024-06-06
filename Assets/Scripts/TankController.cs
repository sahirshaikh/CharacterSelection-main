
using UnityEngine;

public class TankController 
{
    [SerializeField] private TankModel tankModel;
    [SerializeField] private TankView tankView;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = _tankView;

        GameObject.Instantiate(tankView.gameObject);

    }
        
 
}
