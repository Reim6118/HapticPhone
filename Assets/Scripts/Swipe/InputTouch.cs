//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Swipe/InputTouch.inputactions
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

public partial class @InputTouch : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputTouch()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputTouch"",
    ""maps"": [
        {
            ""name"": ""TouchInput"",
            ""id"": ""26a5c8c5-5f86-4bf2-b6b4-2a78d31eddbb"",
            ""actions"": [
                {
                    ""name"": ""PrimaryContact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""df287ed5-ab5b-4770-bd70-75d2089293a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PrimaryPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""548f69a1-168e-4e99-a827-2ff43923b6bd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a4fece6a-1dd4-4814-a5c1-8216787814ac"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45ecf656-f74e-4ef0-8f6c-98c7aa2bac62"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TouchInput
        m_TouchInput = asset.FindActionMap("TouchInput", throwIfNotFound: true);
        m_TouchInput_PrimaryContact = m_TouchInput.FindAction("PrimaryContact", throwIfNotFound: true);
        m_TouchInput_PrimaryPosition = m_TouchInput.FindAction("PrimaryPosition", throwIfNotFound: true);
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

    // TouchInput
    private readonly InputActionMap m_TouchInput;
    private ITouchInputActions m_TouchInputActionsCallbackInterface;
    private readonly InputAction m_TouchInput_PrimaryContact;
    private readonly InputAction m_TouchInput_PrimaryPosition;
    public struct TouchInputActions
    {
        private @InputTouch m_Wrapper;
        public TouchInputActions(@InputTouch wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryContact => m_Wrapper.m_TouchInput_PrimaryContact;
        public InputAction @PrimaryPosition => m_Wrapper.m_TouchInput_PrimaryPosition;
        public InputActionMap Get() { return m_Wrapper.m_TouchInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchInputActions set) { return set.Get(); }
        public void SetCallbacks(ITouchInputActions instance)
        {
            if (m_Wrapper.m_TouchInputActionsCallbackInterface != null)
            {
                @PrimaryContact.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryContact;
                @PrimaryContact.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryContact;
                @PrimaryContact.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryContact;
                @PrimaryPosition.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryPosition;
                @PrimaryPosition.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryPosition;
                @PrimaryPosition.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryPosition;
            }
            m_Wrapper.m_TouchInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryContact.started += instance.OnPrimaryContact;
                @PrimaryContact.performed += instance.OnPrimaryContact;
                @PrimaryContact.canceled += instance.OnPrimaryContact;
                @PrimaryPosition.started += instance.OnPrimaryPosition;
                @PrimaryPosition.performed += instance.OnPrimaryPosition;
                @PrimaryPosition.canceled += instance.OnPrimaryPosition;
            }
        }
    }
    public TouchInputActions @TouchInput => new TouchInputActions(this);
    public interface ITouchInputActions
    {
        void OnPrimaryContact(InputAction.CallbackContext context);
        void OnPrimaryPosition(InputAction.CallbackContext context);
    }
}
