using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Vitesse du personnage
    private Vector2 movement;     // Stocke le mouvement

    public Rigidbody2D rb;        // Référence au Rigidbody2D

    void Update()
    {
        // Récupération de l'input des touches ZQSD
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Appliquer le mouvement au Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D Collider2D)
    {
        if (Collider2D.tag == "piege")
        {
            transform.position = new Vector3(-8.86f, -3.52f, 0f);
        }
    }
}