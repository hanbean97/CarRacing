using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientState : MonoBehaviour
{
    private BikeController _bikeController;
    void Start()
    {
        _bikeController = GetComponent<BikeController>();
    }
    private void OnGUI()
    {
        if(GUILayout.Button("Start Button"))
        {
            _bikeController.StartBike();
        }
        if (GUILayout.Button("Turn Left"))
        {
            _bikeController.Turn(Direction.left);
        }
        if (GUILayout.Button("Turn Right"))
        {
            _bikeController.Turn(Direction.right);
        }
        if (GUILayout.Button("Stop Button"))
        {
            _bikeController.StopBike() ;
        }

    }

}
