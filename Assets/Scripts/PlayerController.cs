using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Transform _bulletSpawner;
    [SerializeField] Bullets _bulletPrefab;

    private void Start()
    {
        _playerInput.currentActionMap.Enable();
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

    private void OnMovement(InputValue Value)
    {

    }

    private void OnShoot()
    {
        Instantiate(_bulletPrefab, _bulletSpawner.position, transform.rotation);
    }
}
