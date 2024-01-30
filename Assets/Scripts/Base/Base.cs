using TMPro;
using UnityEngine;

namespace ThePrototype.Scripts.Base
{
    public class Base : MonoBehaviour
    {
        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        /// <summary>
        /// Set Activation with parameter.
        /// </summary>
        /// <param name="state">True => Active ; False =>Deactive </param>
        public void ActivationState(bool state)
        {
            gameObject.SetActive(state);
        }
    }
}