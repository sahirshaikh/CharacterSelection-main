
using UnityEngine;

public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rigidbody;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);

        rigidbody = tankView.GetRigidBody();

        tankModel.SetTankController(this);
        tankView.SetTankController(this);
        

    }

    public void Move(float _movement, float _movementSpeed)
    {
        rigidbody.velocity = tankView.transform.forward *_movement* _movementSpeed;

    }

    public void Rotate(float _rotation, float _rotationSpeed)
    {
        Vector3 vector = new Vector3(0f,_rotation*_rotationSpeed,0f);
        Quaternion deltaRotation = Quaternion.Euler(vector*Time.deltaTime);
        rigidbody.MoveRotation(rigidbody.rotation*deltaRotation);

    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }


        
 
}
