using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record : MonoBehaviour {

	void Start () {
        GetComponent<Race>().leftSide = GetVeryParent().GetComponent<Race>().leftSide;
    }
	
	void Update () {

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Body") && collision.GetComponent<Race>().leftSide != GetComponent<Race>().leftSide)
        {
            collision.GetComponent<Body>().Damage(10);

        }
    }

    GameObject GetVeryParent()
    {
        GameObject gm;
        gm = gameObject;
        while(gm.transform.parent != null)
        {
            gm = (GameObject)gm.transform.parent.gameObject;
        }
        return gm;
    }
}
