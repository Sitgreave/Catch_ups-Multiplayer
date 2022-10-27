using BH_Player.Attributes;
using BH_Player.InputHandle;
using Mirror;
using BH_Player.Moving;
using BH_Player.Spell;
using UnityEngine;


namespace BH_Player
{
    public class Player : NetworkBehaviour
    {
        [SerializeField] private PlayerAttributes _playerAttributesBundle;
        [SerializeField] private CharacterController _characterController;
        private Movement _movement;
        private InputHandler _inputHandler;
        private SpellHandler _spellHandler;

        private void Start()
        {
            if (isLocalPlayer)
            {
                _inputHandler = InputHandler.Instance;
                _movement = new Movement(_playerAttributesBundle.MoveAttribute, _characterController, _inputHandler);
            }
        }
    

        private void Update()
        {
            if (isLocalPlayer)
            {
                _movement?.OnUpdate();
            }
        }

       

       
        
    }
}