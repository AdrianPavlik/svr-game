using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    ActionMap playerController;
    CharacterController characterController;
    public Image mapImage;
    //public GameObject avatar;
    public new GameObject camera;
    [Range(5f, 30f)]
    public float moveSpeed = 150f;
    [Range(0.5f, 5f)]
    public float rotationSpeed = 1f;
    bool buttonPressed = false;

    public GameObject player;
    public GameObject portal;

    private void Awake()
    {
        characterController = camera.GetComponent<CharacterController>();
        playerController = new ActionMap();
    }

    private void Update()
    {
        camera.transform.localPosition = new Vector3(0, 0.35f, 0);
        Move();
    }

    private void Move()
    {
        if ((playerController.KeyboardPlayer.OpenMap.ReadValue<float>() == 1 || playerController.HeadsetPlayer.OpenMap.ReadValue<float>() == 1) && !buttonPressed)
        {
            mapImage.enabled = !mapImage.enabled;
            buttonPressed = true;
        };
        if (playerController.KeyboardPlayer.OpenMap.ReadValue<float>() == 0 && buttonPressed)
        {
            buttonPressed = false;
        }
        Vector2 m = playerController.KeyboardPlayer.Move.ReadValue<Vector2>();
        Vector3 movement = (m.y * camera.transform.forward) + (m.x * camera.transform.right);
        characterController.Move(moveSpeed * Time.deltaTime * movement);
    }

    private void OnEnable()
    {
        playerController.KeyboardPlayer.Enable();
    }

    private void OnDisable()
    {
        playerController.KeyboardPlayer.Disable();
    }
}
