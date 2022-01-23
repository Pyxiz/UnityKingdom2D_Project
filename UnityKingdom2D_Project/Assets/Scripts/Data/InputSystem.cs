// GENERATED AUTOMATICALLY FROM 'Assets/Resources/Data/InputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""36d8c3f3-05ac-4f26-bc29-f5cd5bc15e93"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""41b97ed9-1c62-49bc-8be0-cdb43c458e31"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackAction"",
                    ""type"": ""Button"",
                    ""id"": ""62f3e438-74c7-40e0-8a22-4b779f12bd87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill_1"",
                    ""type"": ""Button"",
                    ""id"": ""c1965166-0b03-4b17-8bbc-89f1176ca6cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill_2"",
                    ""type"": ""Button"",
                    ""id"": ""6e33e4b3-3902-45df-9c40-13b360a9de16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item_1"",
                    ""type"": ""Button"",
                    ""id"": ""3424dcfe-795e-483a-8609-cbdd7690b7ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item_2"",
                    ""type"": ""Button"",
                    ""id"": ""1f741bee-2af4-4a63-b930-587c1a3ddb0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Map"",
                    ""type"": ""Button"",
                    ""id"": ""eff6fffb-177e-4a1c-ab92-f63c204f219e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""f3466687-52fa-4b14-b2e2-f00cd27fd25f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1e0cbeaa-7d24-4e08-b4a4-1f8ffc345dbb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63f9a70a-2bf1-40ae-bd6c-1450fa8514d4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""AttackAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8fb809d-c0ac-48a3-8070-8235a80de7b3"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Skill_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""556f670c-36aa-406a-8cf1-b0f6b34b8bf6"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Skill_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a46eb86a-889b-4634-97f2-1699c20ca664"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Skill_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09ce8292-8231-4a63-a049-3f19c0c7e75d"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Skill_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e47c5db-a551-4273-957c-70205fd4efd0"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Item_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bc34718-0e89-4f4a-8ab1-85205dfe0bed"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Item_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""635ddc19-a79b-4943-b09a-1b70c1655d3b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Item_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb309e7b-388f-41fb-a834-9f3eaf121831"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Item_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f692486a-3c6b-400e-a920-b8d83f57199b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b6cfd4a-c97f-4565-a0c0-bcaf8463e462"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7b1f54e-4489-4e5d-947b-73b1daa6a9f3"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1f0f6ca-b0b9-4116-887b-70c09ac53889"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9e6b3da-040e-425d-85e8-ebdb9309fa00"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f4b90c6-5433-4d81-bc2d-5380ae82bbab"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Key_Move"",
                    ""id"": ""58a0a915-ee50-47cf-8aad-dff524413463"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7e1df84a-f0b6-4406-8bac-5d4e8a41dbac"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c2947313-395c-458a-a71a-6b1a66ae70e6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0fdb4b53-3fb7-4406-93c0-a57c6e753dbb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""176f0324-75bb-4d55-8dc2-0b014e6b67f3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d06f8426-7bb1-42a9-b1ff-4623e37ffafd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e58f76cb-63d3-43b7-9f19-be0d9cacc9da"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""267b04b4-54ae-464c-840c-90fa5c3a84e7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""05ebc81c-c84b-4b11-b21a-23b59ec6924c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""GameUI"",
            ""id"": ""fbf8e72d-5c57-4663-a6fe-92645ed65fc5"",
            ""actions"": [
                {
                    ""name"": ""Navigation"",
                    ""type"": ""Value"",
                    ""id"": ""756ff7e0-4d6a-4f2f-9d93-43298ebcc4d5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""6c54fec1-7deb-4f14-aa24-55fc3dee58c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""aeb226ca-0ebd-4cfd-9d61-101612c33ecf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2de965ed-3875-41f9-9c9d-7809de1ce134"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""65a2744c-0b64-4ea5-8c6b-6b50cbce43d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""34435e2b-7fcc-4658-a2b6-fc0d8b464cdc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2249ef2a-d524-47b6-9350-9f2fd2a39e80"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Key_Move"",
                    ""id"": ""62b4595c-250f-45f9-aa17-f0b6426c031e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e6dd75ee-7e0e-41dc-8aac-364f2f04cfb5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c2f674ba-9839-44e8-908d-29dd60b61c35"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e06d7446-14db-4b68-9e81-00a1de804434"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c7e08f4b-5f01-40bf-b616-dbb241733ea3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Pad_Move"",
                    ""id"": ""89730226-7b3a-456f-abaf-8d674d682783"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2164325f-529f-4a2a-ab6a-947b9bbb41e8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""982b4892-d564-4512-ae1e-ebb0cbe8466e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""90d65671-b760-473d-8ae8-742144ae1fbd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""086d9979-f900-4bd9-a272-98325c85d526"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8adb0cd3-a7d3-47d1-b3e0-d12a7b42a1f1"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc3af9b0-337e-416a-a1bf-74df3f4c5794"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf201650-769a-4dae-9a92-cbb62d36f6de"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc9f731a-540c-44ec-9380-a35d69e5c81e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""812954db-066f-41d7-832f-03326a3ce666"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Movement = m_GamePlay.FindAction("Movement", throwIfNotFound: true);
        m_GamePlay_AttackAction = m_GamePlay.FindAction("AttackAction", throwIfNotFound: true);
        m_GamePlay_Skill_1 = m_GamePlay.FindAction("Skill_1", throwIfNotFound: true);
        m_GamePlay_Skill_2 = m_GamePlay.FindAction("Skill_2", throwIfNotFound: true);
        m_GamePlay_Item_1 = m_GamePlay.FindAction("Item_1", throwIfNotFound: true);
        m_GamePlay_Item_2 = m_GamePlay.FindAction("Item_2", throwIfNotFound: true);
        m_GamePlay_Map = m_GamePlay.FindAction("Map", throwIfNotFound: true);
        m_GamePlay_Pause = m_GamePlay.FindAction("Pause", throwIfNotFound: true);
        // GameUI
        m_GameUI = asset.FindActionMap("GameUI", throwIfNotFound: true);
        m_GameUI_Navigation = m_GameUI.FindAction("Navigation", throwIfNotFound: true);
        m_GameUI_Submit = m_GameUI.FindAction("Submit", throwIfNotFound: true);
        m_GameUI_Cancel = m_GameUI.FindAction("Cancel", throwIfNotFound: true);
        m_GameUI_Point = m_GameUI.FindAction("Point", throwIfNotFound: true);
        m_GameUI_Click = m_GameUI.FindAction("Click", throwIfNotFound: true);
        m_GameUI_ScrollWheel = m_GameUI.FindAction("ScrollWheel", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Movement;
    private readonly InputAction m_GamePlay_AttackAction;
    private readonly InputAction m_GamePlay_Skill_1;
    private readonly InputAction m_GamePlay_Skill_2;
    private readonly InputAction m_GamePlay_Item_1;
    private readonly InputAction m_GamePlay_Item_2;
    private readonly InputAction m_GamePlay_Map;
    private readonly InputAction m_GamePlay_Pause;
    public struct GamePlayActions
    {
        private @InputSystem m_Wrapper;
        public GamePlayActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GamePlay_Movement;
        public InputAction @AttackAction => m_Wrapper.m_GamePlay_AttackAction;
        public InputAction @Skill_1 => m_Wrapper.m_GamePlay_Skill_1;
        public InputAction @Skill_2 => m_Wrapper.m_GamePlay_Skill_2;
        public InputAction @Item_1 => m_Wrapper.m_GamePlay_Item_1;
        public InputAction @Item_2 => m_Wrapper.m_GamePlay_Item_2;
        public InputAction @Map => m_Wrapper.m_GamePlay_Map;
        public InputAction @Pause => m_Wrapper.m_GamePlay_Pause;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                @AttackAction.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttackAction;
                @AttackAction.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttackAction;
                @AttackAction.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttackAction;
                @Skill_1.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill_1;
                @Skill_1.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill_1;
                @Skill_1.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill_1;
                @Skill_2.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill_2;
                @Skill_2.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill_2;
                @Skill_2.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill_2;
                @Item_1.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnItem_1;
                @Item_1.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnItem_1;
                @Item_1.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnItem_1;
                @Item_2.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnItem_2;
                @Item_2.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnItem_2;
                @Item_2.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnItem_2;
                @Map.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMap;
                @Map.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMap;
                @Map.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMap;
                @Pause.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @AttackAction.started += instance.OnAttackAction;
                @AttackAction.performed += instance.OnAttackAction;
                @AttackAction.canceled += instance.OnAttackAction;
                @Skill_1.started += instance.OnSkill_1;
                @Skill_1.performed += instance.OnSkill_1;
                @Skill_1.canceled += instance.OnSkill_1;
                @Skill_2.started += instance.OnSkill_2;
                @Skill_2.performed += instance.OnSkill_2;
                @Skill_2.canceled += instance.OnSkill_2;
                @Item_1.started += instance.OnItem_1;
                @Item_1.performed += instance.OnItem_1;
                @Item_1.canceled += instance.OnItem_1;
                @Item_2.started += instance.OnItem_2;
                @Item_2.performed += instance.OnItem_2;
                @Item_2.canceled += instance.OnItem_2;
                @Map.started += instance.OnMap;
                @Map.performed += instance.OnMap;
                @Map.canceled += instance.OnMap;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);

    // GameUI
    private readonly InputActionMap m_GameUI;
    private IGameUIActions m_GameUIActionsCallbackInterface;
    private readonly InputAction m_GameUI_Navigation;
    private readonly InputAction m_GameUI_Submit;
    private readonly InputAction m_GameUI_Cancel;
    private readonly InputAction m_GameUI_Point;
    private readonly InputAction m_GameUI_Click;
    private readonly InputAction m_GameUI_ScrollWheel;
    public struct GameUIActions
    {
        private @InputSystem m_Wrapper;
        public GameUIActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigation => m_Wrapper.m_GameUI_Navigation;
        public InputAction @Submit => m_Wrapper.m_GameUI_Submit;
        public InputAction @Cancel => m_Wrapper.m_GameUI_Cancel;
        public InputAction @Point => m_Wrapper.m_GameUI_Point;
        public InputAction @Click => m_Wrapper.m_GameUI_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_GameUI_ScrollWheel;
        public InputActionMap Get() { return m_Wrapper.m_GameUI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameUIActions set) { return set.Get(); }
        public void SetCallbacks(IGameUIActions instance)
        {
            if (m_Wrapper.m_GameUIActionsCallbackInterface != null)
            {
                @Navigation.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnNavigation;
                @Navigation.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnNavigation;
                @Navigation.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnNavigation;
                @Submit.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnScrollWheel;
            }
            m_Wrapper.m_GameUIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigation.started += instance.OnNavigation;
                @Navigation.performed += instance.OnNavigation;
                @Navigation.canceled += instance.OnNavigation;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
            }
        }
    }
    public GameUIActions @GameUI => new GameUIActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IGamePlayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttackAction(InputAction.CallbackContext context);
        void OnSkill_1(InputAction.CallbackContext context);
        void OnSkill_2(InputAction.CallbackContext context);
        void OnItem_1(InputAction.CallbackContext context);
        void OnItem_2(InputAction.CallbackContext context);
        void OnMap(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IGameUIActions
    {
        void OnNavigation(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
    }
}
