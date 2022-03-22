using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Animator))]
    public class PlayerAnimator : MonoBehaviour
    {
        public float AnimationSpeed = 2;
        private Animator _animator;
        private string _animatorSpeedParameter = "Speed";

        private void Start() =>
            _animator = GetComponent<Animator>();
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0)) RunAnimation();
            if (Input.GetMouseButtonUp(0)) IdleAnimation();
        }
        private void RunAnimation() => _animator.SetFloat(_animatorSpeedParameter, AnimationSpeed);

        private void IdleAnimation() => _animator.SetFloat(_animatorSpeedParameter, 0);
        
    }
}