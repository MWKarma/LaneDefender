using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Transform _bulletSpawner;
    [SerializeField] Bullets _bulletPrefab;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    [SerializeField] private float _direction;
    [SerializeField] private bool _isMoving;
    [SerializeField] private GameObject _player;

    private InputAction _movement;

    private void Start()
    {
        _playerInput.currentActionMap.Enable();

        _movement = _playerInput.currentActionMap.FindAction("Movement");

        _movement.started += _movement_started;
        _movement.canceled += _movement_canceled;

        _isMoving = false;
    }

    private void _movement_canceled(InputAction.CallbackContext obj)
    {
        _isMoving = false;
        print("Not moving");
    }

    private void _movement_started(InputAction.CallbackContext obj)
    {
        _isMoving = true;
        print("Moving");
    }

    private void Update()
    {
        if (_isMoving)
        {
            _direction = _movement.ReadValue<float>();
        }
    }
    private void OnQuit()
    {
        Application.Quit();
        print("Bye Bye!");
    }

    private void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Welcome Back");
    }
    private void OnShoot()
    {
        Instantiate(_bulletPrefab, _bulletSpawner.position, transform.rotation);
    }

    private void FixedUpdate()
    {
        if(_isMoving == true)
        {
            _player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, _speed * _direction);
        }
        else
        {
            _player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
