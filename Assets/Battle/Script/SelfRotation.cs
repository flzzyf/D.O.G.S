using UnityEngine;

public class SelfRotation : MonoBehaviour
{
    public float rotSpeed = 50;

    public bool Clockwise = false;

    void Update()
    {
        if(Clockwise)
            transform.Rotate(new Vector3(0, 0, -rotSpeed));
        else
            transform.Rotate(new Vector3(0, 0, rotSpeed));

    }
}