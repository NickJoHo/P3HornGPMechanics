using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    // Degrees per second base speed (tweak in Inspector)
    public float rotationSpeed = 180f;
    // Hold boostKey to multiply rotationSpeed for fast rotation
    public float boostMultiplier = 3f;
    public KeyCode boostKey = KeyCode.LeftShift;

    void Start()
    {
    }

    void Update()
    {
        // Use GetAxisRaw for immediate full input (-1/0/1)
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float currentSpeed = rotationSpeed * (Input.GetKey(boostKey) ? boostMultiplier : 1f);
        transform.Rotate(Vector3.up, horizontalInput * currentSpeed * Time.deltaTime);
    }
}
