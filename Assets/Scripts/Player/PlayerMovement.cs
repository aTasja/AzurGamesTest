using System;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        public float MovementSpeed = 2;
        
        [SerializeField] private Camera _camera;
        
        private CharacterController _characterController;
        private float _minXpos = -3f;
        private float _maxXpos = 3f;
        

        private void Start() => _characterController = GetComponent<CharacterController>();

        private void Update()
        {
            if (Input.GetMouseButton(0)) {
                Move();
                FollowMousePositionX();
            }
        }
        
        private void Move() {
            _characterController.Move(Vector3.forward * MovementSpeed * Time.deltaTime);
        }

        private void FollowMousePositionX()
        {
            var ray =_camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (!Physics.Raycast(ray, out hit)) return;

            var pos = transform.position;
            var clampedPosX = Mathf.Clamp(hit.point.x, _minXpos, _maxXpos);
            var target = new Vector3(clampedPosX, pos.y, pos.z);
            var distance = Vector3.Distance(transform.position, target);
            transform.position = Vector3.MoveTowards(pos, target,  distance * MovementSpeed* Time.deltaTime);
        }
    }
}
