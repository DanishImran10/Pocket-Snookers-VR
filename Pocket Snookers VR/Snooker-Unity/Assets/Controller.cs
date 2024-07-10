//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Controller.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controller: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""e78c98ea-03ee-496d-8d0f-2f96f5cf4436"",
            ""actions"": [
                {
                    ""name"": ""StickRotation"",
                    ""type"": ""Value"",
                    ""id"": ""00df2b6f-a3d1-4b22-9aa1-c242284aa8fa"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SettingAim"",
                    ""type"": ""Value"",
                    ""id"": ""6c2a8466-10a4-42e7-a465-fddcb1ba2fe0"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotateToAim"",
                    ""type"": ""Button"",
                    ""id"": ""e04eb1b1-aa73-41a8-b598-ac84fe43d69e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AimToRotate"",
                    ""type"": ""Button"",
                    ""id"": ""72002333-4d0b-4051-8498-43a2b091a3a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotationSet"",
                    ""type"": ""Button"",
                    ""id"": ""a9e8fb3d-1f55-44fa-b58c-0462d722a770"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AimToPower"",
                    ""type"": ""Button"",
                    ""id"": ""cb3ea850-bdcd-4d30-b79a-ad9d235dbdcc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PowerTranslate"",
                    ""type"": ""Value"",
                    ""id"": ""a4d2887c-5917-467b-b744-4024b4a5cd77"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Hit"",
                    ""type"": ""Button"",
                    ""id"": ""378eb683-3f5a-4774-95e8-3a94e2c25806"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2707c807-b4bc-4391-9cc6-e0b6b3641a5d"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationSet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6a44727-48a3-489e-81a0-0d6240a28425"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""eb24f953-f84a-4c12-9095-1bf3a69181cc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SettingAim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""510c1817-a673-4e02-8d01-16c5632e8f8b"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SettingAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e81952c7-2de9-4fb8-befa-1d3b5c1e32cb"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SettingAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2cd10033-8291-4a1a-bdb6-841e5160b2e9"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SettingAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e722e975-f7df-4eae-9413-b1d5a8b2a5f2"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SettingAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""13dc6870-8c9b-4562-8981-43593a58d588"",
                    ""path"": ""<HID::248A-8266>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateToAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef639f48-2db7-4a1b-a4d4-025aa766a5c2"",
                    ""path"": ""<HID::248A-8266>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimToRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94b6d27b-70ee-4dba-ac1f-e0f2f9eac015"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimToPower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""10b47486-0c73-4c7c-ad1e-5c72735bb5e6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0f9eb07a-e61f-4e17-83dd-1e4029d7f178"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7aeb994b-0d92-457d-99ad-a8747b33602d"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6b93f376-30bd-4315-9e1e-0aedd0cf16a1"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""51ade5b4-8f17-47e3-9478-809aedbaac4c"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""80b879b4-43d5-47f3-bd5a-7bbf12a33cd3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerTranslate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b0143db6-09fe-46d8-bb19-f0d4149ded1c"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerTranslate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eab7d61d-505e-424a-a79a-068cf7bfb1a4"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerTranslate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""80fa49e8-2842-4373-a65c-ec9ffaa5ac30"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerTranslate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""af1df638-b2c7-468b-859e-11e12b9531ac"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerTranslate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_StickRotation = m_Gameplay.FindAction("StickRotation", throwIfNotFound: true);
        m_Gameplay_SettingAim = m_Gameplay.FindAction("SettingAim", throwIfNotFound: true);
        m_Gameplay_RotateToAim = m_Gameplay.FindAction("RotateToAim", throwIfNotFound: true);
        m_Gameplay_AimToRotate = m_Gameplay.FindAction("AimToRotate", throwIfNotFound: true);
        m_Gameplay_RotationSet = m_Gameplay.FindAction("RotationSet", throwIfNotFound: true);
        m_Gameplay_AimToPower = m_Gameplay.FindAction("AimToPower", throwIfNotFound: true);
        m_Gameplay_PowerTranslate = m_Gameplay.FindAction("PowerTranslate", throwIfNotFound: true);
        m_Gameplay_Hit = m_Gameplay.FindAction("Hit", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_StickRotation;
    private readonly InputAction m_Gameplay_SettingAim;
    private readonly InputAction m_Gameplay_RotateToAim;
    private readonly InputAction m_Gameplay_AimToRotate;
    private readonly InputAction m_Gameplay_RotationSet;
    private readonly InputAction m_Gameplay_AimToPower;
    private readonly InputAction m_Gameplay_PowerTranslate;
    private readonly InputAction m_Gameplay_Hit;
    public struct GameplayActions
    {
        private @Controller m_Wrapper;
        public GameplayActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @StickRotation => m_Wrapper.m_Gameplay_StickRotation;
        public InputAction @SettingAim => m_Wrapper.m_Gameplay_SettingAim;
        public InputAction @RotateToAim => m_Wrapper.m_Gameplay_RotateToAim;
        public InputAction @AimToRotate => m_Wrapper.m_Gameplay_AimToRotate;
        public InputAction @RotationSet => m_Wrapper.m_Gameplay_RotationSet;
        public InputAction @AimToPower => m_Wrapper.m_Gameplay_AimToPower;
        public InputAction @PowerTranslate => m_Wrapper.m_Gameplay_PowerTranslate;
        public InputAction @Hit => m_Wrapper.m_Gameplay_Hit;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @StickRotation.started += instance.OnStickRotation;
            @StickRotation.performed += instance.OnStickRotation;
            @StickRotation.canceled += instance.OnStickRotation;
            @SettingAim.started += instance.OnSettingAim;
            @SettingAim.performed += instance.OnSettingAim;
            @SettingAim.canceled += instance.OnSettingAim;
            @RotateToAim.started += instance.OnRotateToAim;
            @RotateToAim.performed += instance.OnRotateToAim;
            @RotateToAim.canceled += instance.OnRotateToAim;
            @AimToRotate.started += instance.OnAimToRotate;
            @AimToRotate.performed += instance.OnAimToRotate;
            @AimToRotate.canceled += instance.OnAimToRotate;
            @RotationSet.started += instance.OnRotationSet;
            @RotationSet.performed += instance.OnRotationSet;
            @RotationSet.canceled += instance.OnRotationSet;
            @AimToPower.started += instance.OnAimToPower;
            @AimToPower.performed += instance.OnAimToPower;
            @AimToPower.canceled += instance.OnAimToPower;
            @PowerTranslate.started += instance.OnPowerTranslate;
            @PowerTranslate.performed += instance.OnPowerTranslate;
            @PowerTranslate.canceled += instance.OnPowerTranslate;
            @Hit.started += instance.OnHit;
            @Hit.performed += instance.OnHit;
            @Hit.canceled += instance.OnHit;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @StickRotation.started -= instance.OnStickRotation;
            @StickRotation.performed -= instance.OnStickRotation;
            @StickRotation.canceled -= instance.OnStickRotation;
            @SettingAim.started -= instance.OnSettingAim;
            @SettingAim.performed -= instance.OnSettingAim;
            @SettingAim.canceled -= instance.OnSettingAim;
            @RotateToAim.started -= instance.OnRotateToAim;
            @RotateToAim.performed -= instance.OnRotateToAim;
            @RotateToAim.canceled -= instance.OnRotateToAim;
            @AimToRotate.started -= instance.OnAimToRotate;
            @AimToRotate.performed -= instance.OnAimToRotate;
            @AimToRotate.canceled -= instance.OnAimToRotate;
            @RotationSet.started -= instance.OnRotationSet;
            @RotationSet.performed -= instance.OnRotationSet;
            @RotationSet.canceled -= instance.OnRotationSet;
            @AimToPower.started -= instance.OnAimToPower;
            @AimToPower.performed -= instance.OnAimToPower;
            @AimToPower.canceled -= instance.OnAimToPower;
            @PowerTranslate.started -= instance.OnPowerTranslate;
            @PowerTranslate.performed -= instance.OnPowerTranslate;
            @PowerTranslate.canceled -= instance.OnPowerTranslate;
            @Hit.started -= instance.OnHit;
            @Hit.performed -= instance.OnHit;
            @Hit.canceled -= instance.OnHit;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnStickRotation(InputAction.CallbackContext context);
        void OnSettingAim(InputAction.CallbackContext context);
        void OnRotateToAim(InputAction.CallbackContext context);
        void OnAimToRotate(InputAction.CallbackContext context);
        void OnRotationSet(InputAction.CallbackContext context);
        void OnAimToPower(InputAction.CallbackContext context);
        void OnPowerTranslate(InputAction.CallbackContext context);
        void OnHit(InputAction.CallbackContext context);
    }
}