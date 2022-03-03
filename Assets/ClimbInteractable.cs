using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class ClimbInteractable : XRBaseInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        XRBaseInteractor interactor = (XRBaseInteractor)args.interactorObject;

        base.OnSelectEntered(args);

       

        if (interactor is XRDirectInteractor)
        { Climber.climbingHand = interactor.GetComponent<XRController>(); }
            
    }
    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        XRBaseInteractor interactor = (XRBaseInteractor)args.interactorObject;
        base.OnSelectExited(args);

        if (interactor is XRDirectInteractor)
        {
            if (Climber.climbingHand && Climber.climbingHand.name == interactor.name)
            {
                Climber.climbingHand = null;
            }
        }
    }
}

