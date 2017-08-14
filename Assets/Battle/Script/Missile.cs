using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

    public float speed = 1f;

    public int damage = 20;

    private int direction = 1;

	void Start () {
        if (!GetComponent<Race>().leftSide)
        {
            direction = -1;
            transform.localScale = new Vector3(-1, 1, 1);
        }
	}
	
	void Update () {

        transform.Translate(new Vector3(direction * speed * Time.deltaTime, 0, 0), Space.Self);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Body") && collision.GetComponent<Race>().leftSide != GetComponent<Race>().leftSide)
        {
            collision.GetComponent<Body>().Damage(damage);

            Destroy(gameObject);

        }
    }
}
