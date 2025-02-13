using UnityEngine;

public interface IMovable2
{
    float MoveSpeed { get; set; }
    float Acceleration { get; set; }

    void GoForward();
    void Reverse();
    void TurnLeft();
    void TurnRight();
}

