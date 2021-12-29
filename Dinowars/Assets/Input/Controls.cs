// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""1769102d-858b-4bf3-ac51-fc3e316c1d15"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b67c7fe6-08b8-4a71-afd2-b9bd949ea1f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""d5685280-5da3-47e6-8a58-1c0bf4db648a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TakeDamage"",
                    ""type"": ""Button"",
                    ""id"": ""eb03807e-86a0-4f46-bd76-55efc8f25c09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Heal"",
                    ""type"": ""Button"",
                    ""id"": ""9acab1c4-1c21-43d8-9b69-eabbd4f344d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootByPressing"",
                    ""type"": ""Button"",
                    ""id"": ""970e452d-5241-4fad-af07-a07579ad4af4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootByHolding"",
                    ""type"": ""Button"",
                    ""id"": ""260ebbdf-118c-4cf3-bb52-bc01a7d75a52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a683a8c6-9eec-4988-90a4-6a670cb3bbaf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyborad & Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis AD"",
                    ""id"": ""283c9188-eef3-43e0-b27b-cb00629b3152"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e948471c-0661-401e-ae82-8a6a21aac37c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyborad & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0428e709-49ac-416e-91ac-f8b2d0580571"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyborad & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""04c06243-4781-4b61-9c5b-3c9fc1f24acb"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyborad & Mouse"",
                    ""action"": ""TakeDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eeae6e76-4ebd-4982-a35c-9f1caa1a5690"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyborad & Mouse"",
                    ""action"": ""Heal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6f1e284-de29-4427-b792-789190189733"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyborad & Mouse"",
                    ""action"": ""ShootByPressing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""130c2bee-d0d9-4593-8f43-38307b976641"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyborad & Mouse"",
                    ""action"": ""ShootByHolding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game"",
            ""id"": ""3a0011a6-1252-45e0-a9a4-8fc4fd2e04c9"",
            ""actions"": [
                {
                    ""name"": ""ScoreBoard"",
                    ""type"": ""Button"",
                    ""id"": ""ff0ac4c0-aa0c-4b48-8540-fa144bf8cd43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""78f5cb6c-4298-424b-9cba-58de62780256"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyborad & Mouse"",
                    ""action"": ""ScoreBoard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyborad & Mouse"",
            ""bindingGroup"": ""Keyborad & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_TakeDamage = m_Player.FindAction("TakeDamage", throwIfNotFound: true);
        m_Player_Heal = m_Player.FindAction("Heal", throwIfNotFound: true);
        m_Player_ShootByPressing = m_Player.FindAction("ShootByPressing", throwIfNotFound: true);
        m_Player_ShootByHolding = m_Player.FindAction("ShootByHolding", throwIfNotFound: true);
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_ScoreBoard = m_Game.FindAction("ScoreBoard", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_TakeDamage;
    private readonly InputAction m_Player_Heal;
    private readonly InputAction m_Player_ShootByPressing;
    private readonly InputAction m_Player_ShootByHolding;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @TakeDamage => m_Wrapper.m_Player_TakeDamage;
        public InputAction @Heal => m_Wrapper.m_Player_Heal;
        public InputAction @ShootByPressing => m_Wrapper.m_Player_ShootByPressing;
        public InputAction @ShootByHolding => m_Wrapper.m_Player_ShootByHolding;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @TakeDamage.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeDamage;
                @TakeDamage.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeDamage;
                @TakeDamage.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeDamage;
                @Heal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHeal;
                @Heal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHeal;
                @Heal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHeal;
                @ShootByPressing.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootByPressing;
                @ShootByPressing.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootByPressing;
                @ShootByPressing.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootByPressing;
                @ShootByHolding.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootByHolding;
                @ShootByHolding.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootByHolding;
                @ShootByHolding.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootByHolding;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @TakeDamage.started += instance.OnTakeDamage;
                @TakeDamage.performed += instance.OnTakeDamage;
                @TakeDamage.canceled += instance.OnTakeDamage;
                @Heal.started += instance.OnHeal;
                @Heal.performed += instance.OnHeal;
                @Heal.canceled += instance.OnHeal;
                @ShootByPressing.started += instance.OnShootByPressing;
                @ShootByPressing.performed += instance.OnShootByPressing;
                @ShootByPressing.canceled += instance.OnShootByPressing;
                @ShootByHolding.started += instance.OnShootByHolding;
                @ShootByHolding.performed += instance.OnShootByHolding;
                @ShootByHolding.canceled += instance.OnShootByHolding;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_ScoreBoard;
    public struct GameActions
    {
        private @Controls m_Wrapper;
        public GameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ScoreBoard => m_Wrapper.m_Game_ScoreBoard;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @ScoreBoard.started -= m_Wrapper.m_GameActionsCallbackInterface.OnScoreBoard;
                @ScoreBoard.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnScoreBoard;
                @ScoreBoard.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnScoreBoard;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ScoreBoard.started += instance.OnScoreBoard;
                @ScoreBoard.performed += instance.OnScoreBoard;
                @ScoreBoard.canceled += instance.OnScoreBoard;
            }
        }
    }
    public GameActions @Game => new GameActions(this);
    private int m_KeyboradMouseSchemeIndex = -1;
    public InputControlScheme KeyboradMouseScheme
    {
        get
        {
            if (m_KeyboradMouseSchemeIndex == -1) m_KeyboradMouseSchemeIndex = asset.FindControlSchemeIndex("Keyborad & Mouse");
            return asset.controlSchemes[m_KeyboradMouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnTakeDamage(InputAction.CallbackContext context);
        void OnHeal(InputAction.CallbackContext context);
        void OnShootByPressing(InputAction.CallbackContext context);
        void OnShootByHolding(InputAction.CallbackContext context);
    }
    public interface IGameActions
    {
        void OnScoreBoard(InputAction.CallbackContext context);
    }
}
