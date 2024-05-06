using UnityEngine;

public class Player : MonoBehaviour
{
    public int max_y = -10;
    public Rigidbody2D rb;
    public float jumpForce; 
    public Logic logic;
    public bool birdAlive = true;
    public AudioSource jump;
    public AudioSource over;
    public ParticleSystem death;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
        death.Pause();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive)
        {
            rb.velocity = Vector2.up * jumpForce;
            jump.Play();
        }
      
        if (transform.position.y < max_y)
        {
            GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

    private void GameOver()
    {
        logic.GameOver();
        birdAlive = false;
        Debug.Log("player died");
        over.Play();
        death.Play();
    }
}
