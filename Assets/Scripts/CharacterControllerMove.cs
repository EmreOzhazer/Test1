using UnityEngine;

public class CharacterControllerMove : IMover
{
    readonly CharacterController _characterController;
    float _speed = 5f;

    public CharacterControllerMove(CharacterController characterController)
    {
        _characterController = characterController;
    }

    public void FixedTick(Vector3 moveDirection)
    {
        _characterController.Move(Time.deltaTime * _speed * moveDirection);
    }
}

public interface IMover
{
    void FixedTick(Vector3 moveDirection);
}