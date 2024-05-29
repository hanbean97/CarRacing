using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    [SerializeField] float maxSpeed = 2.0f;
    [SerializeField] float turnDistance = 2.0f;
    public float MaxSpeed { get { return maxSpeed; } }

    public float TurnDistance { get { return turnDistance; } }
    public float CurrentSpeed { get; set; }

   public Direction CurrentTurnDirection { get; private set; }

    private IBikeState _startState, _stopState, _turnState;

    private BikeStateContext _bikeStatContext;
    private void Start()
    {
        _bikeStatContext = new BikeStateContext(this);

       _startState = gameObject.AddComponent<BikeStartState>();
       _stopState = gameObject.AddComponent<BikeStopState>();
       _turnState = gameObject.AddComponent<BikeTurnState>();

        StopBike();
    }

    public void StartBike()
    {
        _bikeStatContext.Transition(_startState);
    }
    public void StopBike()
    {
        _bikeStatContext.Transition(_stopState);
    }
    public void Turn(Direction direction)
    {
        CurrentTurnDirection = direction;
        _bikeStatContext.Transition(_turnState);
    }
}

public enum Direction
{
    left =-1,
    right =1,
}