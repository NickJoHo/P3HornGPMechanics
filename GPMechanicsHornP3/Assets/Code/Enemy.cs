using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedRange = 9.0f;
    public float speed = 5.0f; // Added this line to define 'speed'
    private Rigidbody enemyRb;
    private GameObject player;
    public int enemyCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position -
        transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
