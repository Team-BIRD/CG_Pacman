namespace ThePrototype.Scripts.Base
{
    public interface IInteractable
    {
        public int Point { get; set; }
        public void Interact(IInteractor interactor);
    }
}