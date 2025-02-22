using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        bool isJumpButtonPress = Input.GetButtonDown("Jump");

        playerMovement.Move(horizontalDirection, isJumpButtonPress);
    }
}
