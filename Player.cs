using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Projectile projectilePrefab;
    public int points;
    public float shootInterval;
    public float shootTimer;
    public Transform shootPoint;
    void Shoot()
    {
        if (shootTimer <= 0)
        {
            Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            shootTimer = shootInterval;
        }
    }


    void Update()
    {
        Move();
        shootTimer -= Time.deltaTime;
        Shoot();

    }

    // Update is called once per frame
    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }

    }
}
