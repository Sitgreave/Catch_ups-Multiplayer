using BH_Camera;
using BH_Player.Attributes;
using BH_Player.Spell;
using Mirror;
using Player.Character.Movement;
using UnityEngine;


namespace BH_Player
{
    [RequireComponent(typeof(CameraTarget))]
    public class Player : NetworkBehaviour
    {
        [SerializeField] private PlayerAttributes _playerAttributesBundle;
        [SerializeField] private CharacterController _characterController;
        
        private CameraTarget _cameraTarget;
        private Movement _movement;
        private SpellHandler _spellHandler;

        private void Awake()
        {
            _cameraTarget = GetComponent<CameraTarget>();
        }

        private void Start()
        {
            if (!isLocalPlayer) return;
            
            _cameraTarget.Initialize(Camera.main.GetComponent<CameraTracker>());
            _movement = new Movement(_playerAttributesBundle.MoveAttribute, _characterController);
        }
    

        private void Update()
        {
            if(isLocalPlayer) _movement.Move(_inputHandler.SummaryDirection);
        }

       

       
        
    }
}