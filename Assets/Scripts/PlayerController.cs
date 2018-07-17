using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(0.1f, 1)]
    public float TopSpeed;
    
    [Range(0.01f, 0.1f)]
    public float Acceleration;

    private Rigidbody2D _rigidbody2D;
    
    private float _currentSpeed;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 v = _rigidbody2D.velocity;
            
            if (_currentSpeed < TopSpeed)
            {
                _currentSpeed = Mathf.Clamp(_currentSpeed + Acceleration, 0, TopSpeed);
            }

            v.x += _currentSpeed;
            _rigidbody2D.velocity = v;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 v = _rigidbody2D.velocity;
            
            if (_currentSpeed < TopSpeed)
            {
                _currentSpeed = Mathf.Clamp(_currentSpeed + Acceleration, 0, TopSpeed);
            }

            v.x -= _currentSpeed;
            _rigidbody2D.velocity = v;
        }

    }
}