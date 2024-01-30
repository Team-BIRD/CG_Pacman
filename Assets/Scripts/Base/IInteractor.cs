using UnityEngine;

namespace ThePrototype.Scripts.Base
{
    public interface IInteractor
    {
        public void Interact(IInteractable interactable);
    }
}