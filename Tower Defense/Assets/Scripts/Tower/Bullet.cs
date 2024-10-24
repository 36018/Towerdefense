using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float angle = 45;
    private Vector3 velocity;
    private Vector3 direction;
    private float speed = 15f;
    private float damage = 50;

    public float Angle {
        get { return angle; }
        set { angle = value; }
    }

    public float Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad), 0);
        velocity = direction * speed;
        transform.position += velocity * Time.deltaTime;
    }
}
