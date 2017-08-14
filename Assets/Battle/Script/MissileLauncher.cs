using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour {

    public GameObject missilePrefab;

    public Transform launchPos;

    public float launchCD = 2f;
    private float launchCDTimer = 0;

	void Start () {
	}
	
	void Update () {
		
        if(launchCDTimer >= launchCD)
        {
            //可发射
            launchCDTimer = 0;

            Launch();
        }
        else
        {
            launchCDTimer += Time.deltaTime;
        }

    }

    void Launch()
    {
        GameObject missile = Instantiate(missilePrefab, launchPos.position, launchPos.rotation);
        missile.GetComponent<Race>().leftSide = transform.parent.GetComponent<Race>().leftSide;
    }
}
