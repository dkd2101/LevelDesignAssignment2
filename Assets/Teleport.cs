using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public float teleportX;
    public float teleportY;
    public float teleportZ;

    public bool walkedFarEnough = false;

    public Transform PlayerCapsule;


    // Update is called once per frame
    void Update()
    {
        if (walkedFarEnough)
        {

            if (PlayerCapsule.localEulerAngles.y > 90 && PlayerCapsule.localEulerAngles.y < 180) ;
            {
                print("Teleport");
                PlayerCapsule.position = new Vector3(teleportX, teleportY, teleportZ);

            }
        }


    }


    public void OnTriggerEnter(Collider col)
    {
        print("walkedFarEnough");
        walkedFarEnough = true;
    }
}