using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    [SerializeField] private Rigidbody _rigidbody;

    public MeshRenderer[] child;
    private float movement;
    private float roatation;

    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0.0001f, 3f,-4f);

    }

    void Update()
    {
        Movement();

        if(movement!=0)
        {
            tankController.Move(movement,tankController.GetTankModel().movementSpeed);
        }

        if(roatation!=0)
        {
            tankController.Rotate(roatation,tankController.GetTankModel().rotationSpeed);
        }
        
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        roatation = Input.GetAxis("Horizontal");

    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public Rigidbody GetRigidBody()
    {
        return _rigidbody;
    }

    public void ChangeColor(Material color)
    {
        for(int i = 0; i < child.Length;i++)
        {
            child[i].material = color;
        }

    }

}
