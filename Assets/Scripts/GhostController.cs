using ThePrototype.Scripts.Base;
using UnityEngine;

namespace ThePrototype.Scripts
{
    public class GhostController : Base.Base, IInteractable
    {
        [SerializeField] private int _point;

        public int Point
        {
            get => _point;
            set { _point = value; }
        }

        public bool IsEatable { get; set; }

        public void Interact(IInteractor interactor)
        {
        }
    }
}