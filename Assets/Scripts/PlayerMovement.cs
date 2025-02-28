using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public Transform aim; // Tham chiếu đến Aim

    private Vector2 movement;
    private Vector2 lastDirection = Vector2.down; // Mặc định hướng xuống

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement != Vector2.zero)
        {
            lastDirection = movement.normalized;
        }

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        UpdateAim();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void UpdateAim()
    {
        if (aim != null)
        {
            // Đặt vị trí Aim ở trước mặt người chơi
            aim.localPosition = lastDirection * 0.001f;

            // Xoay Aim đúng hướng
            float angle = Mathf.Atan2(lastDirection.y, lastDirection.x) * Mathf.Rad2Deg;
            aim.rotation = Quaternion.Euler(0, 0, angle + 90); // Đổi từ "-90" thành "+90"
        }
    }
}
