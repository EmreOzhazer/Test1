using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] bool _canMove = false;
    [SerializeField] CharacterController _characterController;
    

    IInputReader _input;
    IMover _mover;
    Vector3 _movementDirection;
    
    void OnValidate()
    {
        if (_characterController == null)
        {
            _characterController = GetComponent<CharacterController>();
        }
    }

    void Awake()
    {
        _input = new OldInputReader();
        _mover = new CharacterControllerMove(_characterController);
       
    }

    void Update()
    {
      
       _movementDirection = _input.MoveDirection;
    }

    void FixedUpdate()
    {
        if(!_canMove)return;
        
        _mover.FixedTick(_movementDirection);
    }
    
}