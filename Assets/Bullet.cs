using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float speed = 50f;
    public int damage = 30;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag != "Player" && hitInfo.gameObject.tag != "Bullet")
        {
            Enemy enemy = hitInfo.GetComponent<Enemy>();
            if (enemy!= null)
            {
                enemy.TakeDamage(damage);
                Score.score += 10;
            }
            Destroy(gameObject);
        }
    }
}
