using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Climber : MonoBehaviour
{
    private CharacterController character;
    public static XRController climbingHand;
    //private ContinousMovement continousMovement;
  
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        //continuousMovement = GetComponent<ContinousMovement>();
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        if (climbingHand)
        {
            Climb();
            //continuousMovement.enabled = false;
        }
        else
        {
           // continuousMovement.enabled = true;
        }
    }
    void Climb()
    {
       
        InputDevices.GetDeviceAtXRNode(climbingHand.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity,out Vector3 velocity);
        character.Move(-velocity * Time.fixedDeltaTime);
   
    }
}
