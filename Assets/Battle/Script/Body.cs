using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour {

	public int maxHP = 100;
    private int hp;

	void Start () {
        hp = maxHP;

        if (!GetComponent<Race>().leftSide)
        {
            //GetComponents<WheelJoint2D>().motor = new JointMotor2D { motorSpeed = 300, maxMotorTorque = 10000 };

            //foreach (Component child in gameObject.GetComponents<WheelJoint2D>)
            //{
            //    Debug.Log(child.name);

            //}
        }
    }
	
	void Update () {
		
	}

    public void Damage(int amount)
    {
        hp -= amount;
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
