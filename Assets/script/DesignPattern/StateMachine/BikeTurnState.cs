using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeTurnState : MonoBehaviour,IBikeState
{
    private Vector3 _turnDirecton;
    private BikeController _bikecontroller;

    public void Handle(BikeController bikeController)
    {
        if(!_bikecontroller )
        {
            _bikecontroller = bikeController;
        }
        _turnDirecton.x = (float)_bikecontroller.CurrentTurnDirection;

        if(_bikecontroller.CurrentSpeed>0)// 회전부문
        {
            transform.Translate(_turnDirecton*_bikecontroller.TurnDistance);
        }
    }
}
