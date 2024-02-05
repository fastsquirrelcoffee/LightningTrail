using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private Animator _animator;

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _characterController.Move(move * _speed * Time.deltaTime);

        if (_characterController.velocity.magnitude > 3f)
            _animator.SetFloat("Speed", 1f);
        else if (_characterController.velocity.magnitude > 1f)
            _animator.SetFloat("Speed", 0.02f);
        else
            _animator.SetFloat("Speed", 0f);
    }
}
