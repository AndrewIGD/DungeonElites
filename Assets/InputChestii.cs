// GENERATED AUTOMATICALLY FROM 'Assets/InputChestii.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputChestii : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputChestii()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputChestii"",
    ""maps"": [
        {
            ""name"": ""GeneralInput"",
            ""id"": ""a129a0e1-2441-4efd-908a-6f2f5f3397f0"",
            ""actions"": [
                {
                    ""name"": ""Left Stick"",
                    ""type"": ""Value"",
                    ""id"": ""da157109-e78a-42e9-bcdf-2af0a3a4b716"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Stick"",
                    ""type"": ""Value"",
                    ""id"": ""f35e0138-e762-45f1-a7ca-fc040041a963"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""c17dffa4-2aa9-4fb8-8139-a20f43470e64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""9925201b-f4ea-4b10-8363-5a16c7f98e66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""2ab5c84a-2c0f-4a8d-bb3f-0820c194a098"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""e718adcb-08ac-4c54-8526-5ab1b2842dba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""3e86986b-e95f-4b9b-9198-4cae24293f47"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""7b2065a4-fa2e-4ec1-9a58-38b177a57ec7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Stick Press"",
                    ""type"": ""Button"",
                    ""id"": ""dc163772-f96c-4359-a135-64771f8f302f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Stick Press"",
                    ""type"": ""Button"",
                    ""id"": ""81c2b9ad-18ab-44d8-85e9-53bdd599fdb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""67b058a2-fa35-4bcd-bf54-021c06379102"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""80c045c3-04b4-43a7-96a4-aa50e782ed20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Bumper"",
                    ""type"": ""Button"",
                    ""id"": ""1749833f-faa3-4d06-8c9c-a5135c542d3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Bumper"",
                    ""type"": ""Button"",
                    ""id"": ""233dc91f-3d19-4704-b916-6cae63d700eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""31f22353-04cc-46e8-9e2a-393a29362071"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e347f56-7d4f-434f-9861-3c5c7544cf1f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4362fe20-7e9b-4b55-bae7-c7cf27e973fb"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ce0e0e3-af68-47c0-8584-56840b0df420"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""919f8909-b758-4080-8aa8-256b067ef224"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17796ce1-c81b-408a-a7d2-40eed513993e"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42d7f858-584e-487c-8239-059dc380822e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""231925b3-f97c-4d77-94af-ea10cf68f5ac"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d41e3b02-76bd-49e8-87a6-9dd915fcd8e9"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e040dfa6-03d2-4d83-a8b0-0d56efde508f"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9442f35-0af6-4b28-a82d-5a2d8e439ce3"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adf97249-b87c-4692-9671-9fc171588eb8"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bea78b3-c9eb-4eae-abda-c1afb88a7a24"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e98ac77-d44e-473a-834b-9eabe518dc10"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7315fd99-3201-41b7-898e-efd00620001d"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60404bd6-037c-4816-8e3d-eca0d92e7270"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8db21072-bab2-47c7-9a6a-8a00ce9b0ea5"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1443e86a-e76d-4a36-92f5-eb6aa38ac040"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92e880b9-41d4-4317-bd39-b8ff8e586d74"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4f50654-9537-42ca-b740-277e9e23bcd7"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1163962-bbd3-4ed1-9d8f-3e4c5a033605"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""871fcd1e-754d-4437-b3c1-424d1d6076dd"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0625989d-6ee1-4729-926b-40c9cfb7ffb7"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3ea683c-8de8-4aa9-9f1e-faf74e29ba29"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03007fc8-97fe-41c0-8aff-79e429e57b01"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Bumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4f3dac9-07ca-4a30-8084-cc91cc76f7c5"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Bumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0864ecb1-79c1-4952-b8f3-f0c3e0e7e5da"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Bumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06c0f31c-75a7-44c6-9be9-cafec15a1ee9"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Bumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GeneralInput
        m_GeneralInput = asset.FindActionMap("GeneralInput", throwIfNotFound: true);
        m_GeneralInput_LeftStick = m_GeneralInput.FindAction("Left Stick", throwIfNotFound: true);
        m_GeneralInput_RightStick = m_GeneralInput.FindAction("Right Stick", throwIfNotFound: true);
        m_GeneralInput_A = m_GeneralInput.FindAction("A", throwIfNotFound: true);
        m_GeneralInput_B = m_GeneralInput.FindAction("B", throwIfNotFound: true);
        m_GeneralInput_X = m_GeneralInput.FindAction("X", throwIfNotFound: true);
        m_GeneralInput_Y = m_GeneralInput.FindAction("Y", throwIfNotFound: true);
        m_GeneralInput_Start = m_GeneralInput.FindAction("Start", throwIfNotFound: true);
        m_GeneralInput_Back = m_GeneralInput.FindAction("Back", throwIfNotFound: true);
        m_GeneralInput_LeftStickPress = m_GeneralInput.FindAction("Left Stick Press", throwIfNotFound: true);
        m_GeneralInput_RightStickPress = m_GeneralInput.FindAction("Right Stick Press", throwIfNotFound: true);
        m_GeneralInput_LeftTrigger = m_GeneralInput.FindAction("Left Trigger", throwIfNotFound: true);
        m_GeneralInput_RightTrigger = m_GeneralInput.FindAction("Right Trigger", throwIfNotFound: true);
        m_GeneralInput_LeftBumper = m_GeneralInput.FindAction("Left Bumper", throwIfNotFound: true);
        m_GeneralInput_RightBumper = m_GeneralInput.FindAction("Right Bumper", throwIfNotFound: true);
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

    // GeneralInput
    private readonly InputActionMap m_GeneralInput;
    private IGeneralInputActions m_GeneralInputActionsCallbackInterface;
    private readonly InputAction m_GeneralInput_LeftStick;
    private readonly InputAction m_GeneralInput_RightStick;
    private readonly InputAction m_GeneralInput_A;
    private readonly InputAction m_GeneralInput_B;
    private readonly InputAction m_GeneralInput_X;
    private readonly InputAction m_GeneralInput_Y;
    private readonly InputAction m_GeneralInput_Start;
    private readonly InputAction m_GeneralInput_Back;
    private readonly InputAction m_GeneralInput_LeftStickPress;
    private readonly InputAction m_GeneralInput_RightStickPress;
    private readonly InputAction m_GeneralInput_LeftTrigger;
    private readonly InputAction m_GeneralInput_RightTrigger;
    private readonly InputAction m_GeneralInput_LeftBumper;
    private readonly InputAction m_GeneralInput_RightBumper;
    public struct GeneralInputActions
    {
        private @InputChestii m_Wrapper;
        public GeneralInputActions(@InputChestii wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftStick => m_Wrapper.m_GeneralInput_LeftStick;
        public InputAction @RightStick => m_Wrapper.m_GeneralInput_RightStick;
        public InputAction @A => m_Wrapper.m_GeneralInput_A;
        public InputAction @B => m_Wrapper.m_GeneralInput_B;
        public InputAction @X => m_Wrapper.m_GeneralInput_X;
        public InputAction @Y => m_Wrapper.m_GeneralInput_Y;
        public InputAction @Start => m_Wrapper.m_GeneralInput_Start;
        public InputAction @Back => m_Wrapper.m_GeneralInput_Back;
        public InputAction @LeftStickPress => m_Wrapper.m_GeneralInput_LeftStickPress;
        public InputAction @RightStickPress => m_Wrapper.m_GeneralInput_RightStickPress;
        public InputAction @LeftTrigger => m_Wrapper.m_GeneralInput_LeftTrigger;
        public InputAction @RightTrigger => m_Wrapper.m_GeneralInput_RightTrigger;
        public InputAction @LeftBumper => m_Wrapper.m_GeneralInput_LeftBumper;
        public InputAction @RightBumper => m_Wrapper.m_GeneralInput_RightBumper;
        public InputActionMap Get() { return m_Wrapper.m_GeneralInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralInputActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralInputActions instance)
        {
            if (m_Wrapper.m_GeneralInputActionsCallbackInterface != null)
            {
                @LeftStick.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftStick;
                @RightStick.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightStick;
                @A.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnY;
                @Start.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnStart;
                @Back.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnBack;
                @LeftStickPress.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftStickPress;
                @LeftStickPress.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftStickPress;
                @LeftStickPress.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftStickPress;
                @RightStickPress.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightStickPress;
                @RightStickPress.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightStickPress;
                @RightStickPress.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightStickPress;
                @LeftTrigger.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftTrigger;
                @RightTrigger.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightTrigger;
                @LeftBumper.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftBumper;
                @LeftBumper.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftBumper;
                @LeftBumper.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnLeftBumper;
                @RightBumper.started -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightBumper;
                @RightBumper.performed -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightBumper;
                @RightBumper.canceled -= m_Wrapper.m_GeneralInputActionsCallbackInterface.OnRightBumper;
            }
            m_Wrapper.m_GeneralInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @LeftStickPress.started += instance.OnLeftStickPress;
                @LeftStickPress.performed += instance.OnLeftStickPress;
                @LeftStickPress.canceled += instance.OnLeftStickPress;
                @RightStickPress.started += instance.OnRightStickPress;
                @RightStickPress.performed += instance.OnRightStickPress;
                @RightStickPress.canceled += instance.OnRightStickPress;
                @LeftTrigger.started += instance.OnLeftTrigger;
                @LeftTrigger.performed += instance.OnLeftTrigger;
                @LeftTrigger.canceled += instance.OnLeftTrigger;
                @RightTrigger.started += instance.OnRightTrigger;
                @RightTrigger.performed += instance.OnRightTrigger;
                @RightTrigger.canceled += instance.OnRightTrigger;
                @LeftBumper.started += instance.OnLeftBumper;
                @LeftBumper.performed += instance.OnLeftBumper;
                @LeftBumper.canceled += instance.OnLeftBumper;
                @RightBumper.started += instance.OnRightBumper;
                @RightBumper.performed += instance.OnRightBumper;
                @RightBumper.canceled += instance.OnRightBumper;
            }
        }
    }
    public GeneralInputActions @GeneralInput => new GeneralInputActions(this);
    public interface IGeneralInputActions
    {
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnLeftStickPress(InputAction.CallbackContext context);
        void OnRightStickPress(InputAction.CallbackContext context);
        void OnLeftTrigger(InputAction.CallbackContext context);
        void OnRightTrigger(InputAction.CallbackContext context);
        void OnLeftBumper(InputAction.CallbackContext context);
        void OnRightBumper(InputAction.CallbackContext context);
    }
}
