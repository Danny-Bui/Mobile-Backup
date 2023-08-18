using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    Rigidbody playerRb;
    Character playerMode;
    Inputs inputs;

    enum ModeTag { Aggressive, Aerial, Evasive }
    ModeTag mode;

    void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        playerMode = new Aggressive(playerRb);
        mode = ModeTag.Aggressive;

        inputs = new Inputs();

        inputs.Player.Change.performed += ctx => ChangeMode();
        inputs.Player.Jump.performed += ctx => Jump();
        inputs.Player.Ability.performed += ctx => Ability();
        inputs.Player.Restart.performed += ctx => RestartLevel();
    }

    private void OnEnable()
    {
        inputs.Player.Enable();
    }

    private void OnDisable()
    {
        inputs.Player.Disable();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 direction = movementValue.Get<Vector2>();
        Vector3 movementInput = new Vector3(direction.x, 0f, direction.y);

        playerMode.Move(movementInput);
    }

    void Update()
    {
        playerMode.Process();
    }

    public void ChangeMode()
    {
        switch (mode)
        {
            case ModeTag.Aggressive:
                Debug.Log("Changing to Aerial");
                playerMode = new Aerial(playerRb);
                mode = ModeTag.Aerial;
                break;
            case ModeTag.Aerial:
                Debug.Log("Changing to Evasive");
                playerMode = new Evasive(playerRb);
                mode = ModeTag.Evasive;
                break;
            case ModeTag.Evasive:
                Debug.Log("Changing to Aggressive");
                playerMode = new Aggressive(playerRb);
                mode = ModeTag.Aggressive;
                break;
        }
    }

    public void Jump()
    {
        playerMode.Jump();
    }

    public void Ability()
    {
        playerMode.Ability();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
