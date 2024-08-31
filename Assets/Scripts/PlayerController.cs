using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerInput PlayerInputInstance;
    [SerializeField] private InputAction movement;
    [SerializeField] private bool MakingYourWayDownTown;
    [SerializeField] private float MoveDirection;
    [SerializeField] private InputAction restart;
    [SerializeField] private InputAction quit;
    [SerializeField] private Rigidbody2D Car;
    [SerializeField] private float CarSpeed;

    private void Start()
    {
        PlayerInputInstance = GetComponent<PlayerInput>();
        PlayerInputInstance.currentActionMap.Enable();
        movement = PlayerInputInstance.currentActionMap.FindAction("Movement");
        restart = PlayerInputInstance.currentActionMap.FindAction("Restart");
        quit = PlayerInputInstance.currentActionMap.FindAction("Quit");

        movement.performed += Movement_performed;
        movement.canceled += Movement_canceled;
        restart.performed += Restart_performed;
        quit.performed += Quit_performed;
    }

    private void Quit_performed(InputAction.CallbackContext obj)
    {
        Application.Quit();
        print("Bye Bye!");
    }

    private void Restart_performed(InputAction.CallbackContext obj)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        print("Whomp Whomp");
    }

    private void Movement_canceled(InputAction.CallbackContext obj)
    {
        MakingYourWayDownTown = false;
        print("Awe Dang It");
    }

    private void Movement_performed(InputAction.CallbackContext obj)
    {
        MakingYourWayDownTown = true;
        print("Let's Be Finacally Responsable!");
    }
}
