using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ThePrototype.Scripts.InputManagement
{
    // [CreateAssetMenu(fileName = "InputManager", menuName = "ThePrototype/Input/InputManager")]
    public class InputManager : PlayerInputActions.IPlayerActions
    {
        public event Action<Vector2> Move = delegate { };

        public static InputManager Instance { get; }
        
        private static PlayerInputActions _playerInputActions;

        static InputManager()
        {
            Instance = new InputManager();
            OnEnable();

        }

        private InputManager(){ }

        private static void OnEnable()
        {
            if (_playerInputActions == null)
            {
                _playerInputActions = new PlayerInputActions();
                _playerInputActions.Player.SetCallbacks(Instance);
            }

            _playerInputActions.Enable();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            Move?.Invoke(context.ReadValue<Vector2>());
        }
    }
}