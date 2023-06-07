// GENERATED AUTOMATICALLY FROM 'Assets/InputManger/ActionMap.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ActionMap : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ActionMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ActionMap"",
    ""maps"": [
        {
            ""name"": ""KeyboardPlayer"",
            ""id"": ""3dee138e-1b64-441a-802b-e7290a59f0ec"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9c95660a-8e01-4267-a9b7-7593f319486f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OpenMap"",
                    ""type"": ""Button"",
                    ""id"": ""2af414a3-3c80-4e15-9de7-32263006df72"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""fab00dc4-a960-4497-a24b-1cbf322eac49"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""246e6bac-d03e-403f-998e-f3fa1d531f4d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dc3dad08-3ba8-46e9-ab52-b9ae89105c94"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""42988558-4d4b-4e80-bc6b-03108ad5778c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""080b84e1-42f0-4b44-a24a-dea16c1b25b1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8f2c2eb7-3b57-4eaf-9eb3-f4d8891312ec"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""HeadsetPlayer"",
            ""id"": ""94fb29a4-bf98-40a6-8643-7addcc6e50e5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ff754cd5-158f-4064-838a-e356b4009ba3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OpenMap"",
                    ""type"": ""Button"",
                    ""id"": ""0362c1a0-7358-45bf-b4a5-417e45bd6bc4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Joystick"",
                    ""id"": ""e8112ceb-0f51-45ce-a9ad-021083969760"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""21829e58-9a25-4e90-9d13-2d23b3665da5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e0fd74cf-6a21-4a37-b0be-369099525ba1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9c04d00e-fc94-4f78-95a4-d0140f27f194"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2d0ed15a-38dd-4b43-bcce-8019a3346d02"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ddc4932a-80c1-4ef4-9946-d74ca3a31917"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyboardPlayer
        m_KeyboardPlayer = asset.FindActionMap("KeyboardPlayer", throwIfNotFound: true);
        m_KeyboardPlayer_Move = m_KeyboardPlayer.FindAction("Move", throwIfNotFound: true);
        m_KeyboardPlayer_OpenMap = m_KeyboardPlayer.FindAction("OpenMap", throwIfNotFound: true);
        // HeadsetPlayer
        m_HeadsetPlayer = asset.FindActionMap("HeadsetPlayer", throwIfNotFound: true);
        m_HeadsetPlayer_Move = m_HeadsetPlayer.FindAction("Move", throwIfNotFound: true);
        m_HeadsetPlayer_OpenMap = m_HeadsetPlayer.FindAction("OpenMap", throwIfNotFound: true);
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

    // KeyboardPlayer
    private readonly InputActionMap m_KeyboardPlayer;
    private IKeyboardPlayerActions m_KeyboardPlayerActionsCallbackInterface;
    private readonly InputAction m_KeyboardPlayer_Move;
    private readonly InputAction m_KeyboardPlayer_OpenMap;
    public struct KeyboardPlayerActions
    {
        private @ActionMap m_Wrapper;
        public KeyboardPlayerActions(@ActionMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_KeyboardPlayer_Move;
        public InputAction @OpenMap => m_Wrapper.m_KeyboardPlayer_OpenMap;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardPlayerActions instance)
        {
            if (m_Wrapper.m_KeyboardPlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_KeyboardPlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_KeyboardPlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_KeyboardPlayerActionsCallbackInterface.OnMove;
                @OpenMap.started -= m_Wrapper.m_KeyboardPlayerActionsCallbackInterface.OnOpenMap;
                @OpenMap.performed -= m_Wrapper.m_KeyboardPlayerActionsCallbackInterface.OnOpenMap;
                @OpenMap.canceled -= m_Wrapper.m_KeyboardPlayerActionsCallbackInterface.OnOpenMap;
            }
            m_Wrapper.m_KeyboardPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @OpenMap.started += instance.OnOpenMap;
                @OpenMap.performed += instance.OnOpenMap;
                @OpenMap.canceled += instance.OnOpenMap;
            }
        }
    }
    public KeyboardPlayerActions @KeyboardPlayer => new KeyboardPlayerActions(this);

    // HeadsetPlayer
    private readonly InputActionMap m_HeadsetPlayer;
    private IHeadsetPlayerActions m_HeadsetPlayerActionsCallbackInterface;
    private readonly InputAction m_HeadsetPlayer_Move;
    private readonly InputAction m_HeadsetPlayer_OpenMap;
    public struct HeadsetPlayerActions
    {
        private @ActionMap m_Wrapper;
        public HeadsetPlayerActions(@ActionMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_HeadsetPlayer_Move;
        public InputAction @OpenMap => m_Wrapper.m_HeadsetPlayer_OpenMap;
        public InputActionMap Get() { return m_Wrapper.m_HeadsetPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeadsetPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IHeadsetPlayerActions instance)
        {
            if (m_Wrapper.m_HeadsetPlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnMove;
                @OpenMap.started -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnOpenMap;
                @OpenMap.performed -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnOpenMap;
                @OpenMap.canceled -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnOpenMap;
            }
            m_Wrapper.m_HeadsetPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @OpenMap.started += instance.OnOpenMap;
                @OpenMap.performed += instance.OnOpenMap;
                @OpenMap.canceled += instance.OnOpenMap;
            }
        }
    }
    public HeadsetPlayerActions @HeadsetPlayer => new HeadsetPlayerActions(this);
    public interface IKeyboardPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnOpenMap(InputAction.CallbackContext context);
    }
    public interface IHeadsetPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnOpenMap(InputAction.CallbackContext context);
    }
}
