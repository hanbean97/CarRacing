using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeStartState : MonoBehaviour,IBikeState
{
    private BikeController _bikecontroller;

    public void Handle(BikeController bikeController)
    {
        if (!_bikecontroller)
        {
            _bikecontroller = bikeController;
        }
        _bikecontroller.CurrentSpeed = _bikecontroller.MaxSpeed;
    }

    public void Update()
    {
        if (_bikecontroller)
        {
            if(_bikecontroller.CurrentSpeed >0)//이동부문
            {
                _bikecontroller.transform.Translate(Vector3.forward *(_bikecontroller.CurrentSpeed*Time.deltaTime));
            }
        }
    }
}
