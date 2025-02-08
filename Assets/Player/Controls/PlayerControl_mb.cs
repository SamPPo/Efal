using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl_mb : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;
    private Vector2 moveInput;

    public InputActionReference moveAction;

    private void Update()
    {
        moveInput = moveAction.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(moveInput.x, 0, moveInput.y) * moveSpeed);
    }
}
