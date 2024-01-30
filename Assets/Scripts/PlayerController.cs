using System;
using ThePrototype.Scripts.Base;
using Unity.VisualScripting;
using UnityEngine;

namespace ThePrototype.Scripts
{
    public class PlayerController : Base.Base, IInteractor
    {
        public event Action<int> OnTakePoint = delegate { };

        public void Interact(IInteractable interactable)
        {
            if (interactable is GhostController ghost)
            {
                if (!ghost.IsEatable)
                {
                    //do something
                    return;
                }
            }
            OnTakePoint?.Invoke(interactable.Point);
        }
    }
}