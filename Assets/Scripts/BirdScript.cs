using UnityEngine;
using UnityEngine.InputSystem;
public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce = 15f;
    public LogicScript logic;
    public bool isAlive = true; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isAlive)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        Time.timeScale = 0f;
        logic.GameOver();
    }
}
