using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeStopState : MonoBehaviour,IBikeState
{
   private BikeController _bikecontroller;

    public void Handle(BikeController bikeController)
    {
        if(!_bikecontroller)
        {
            _bikecontroller = bikeController;
        }
        _bikecontroller.CurrentSpeed = 0;
    }
}
