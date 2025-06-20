using System.Data;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] private float vel = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.linearVelocity = Vector2.up * vel;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocity.y * rotationSpeed);
    }
}
