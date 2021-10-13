using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    public float delay;
    public GameObject arrow;

    private void Start()
    {
        Invoke("Shoot", delay);
    }

    void Shoot()
    {
        GameObject arr = Instantiate(arrow);
        arr.transform.position = transform.position - transform.up * 2;
        arr.transform.eulerAngles = transform.eulerAngles;
        arr.GetComponent<Rigidbody2D>().velocity = 15 * (-arr.transform.up);
        hitbox arrHitbox = arr.GetComponent<hitbox>();
        arrHitbox.parent = gameObject;
        arrHitbox.damage = 50;
        arrHitbox.knockBackSpeed = 3;

        Invoke("Shoot", 3f);
    }
}
