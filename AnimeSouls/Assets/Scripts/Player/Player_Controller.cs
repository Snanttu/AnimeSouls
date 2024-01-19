using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player character
public class Player_Controller : Attack_Object
{
    [SerializeField]
    private float _runSpeed = 1;
    [SerializeField]
    private float _jumpForce = 2.0f;
    [SerializeField]
    private LayerMask _whatIsGround;

    // Weapon combo variables
    private bool _weaponIdle = false;
    private bool _weaponSheathing = false;
    private float _weaponCombo = 0;
    private float _maxCombo = 1;
    private int _attack = 0;    

    private bool _grounded = true;
    private float _horizontal;

    new void Start()
    {
        base.Start();
    }

    new void Update()
    {
        base.Update();
        _horizontal = Input.GetAxisRaw("Horizontal");

        // Ground check
        Collider[] _groundCheck = Physics.OverlapBox(gameObject.transform.position, new Vector3(1, 0.2f, 0.2f), Quaternion.identity, _whatIsGround);

        if (_groundCheck.Length > 0)
        {
            _grounded = true;
        }
        else
        {
            _grounded = false;
        }


        if (_actionCooldown <= 0)
        {
            if (_horizontal != 0)
            {
                // Turn around
                if (_horizontal < 0)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                }
                else
                {
                    transform.localScale = new Vector3(1, 1, 1);
                }
            }

            // Jump
            if (Input.GetKeyDown(KeyCode.Space) && _grounded)
            {
                EndCombo();
                Vector3 jump = new Vector3(0.0f, 2.0f, 0.0f);
                _mainRB.AddForce(jump * _jumpForce, ForceMode.Impulse);
                _grounded = false;
            }

            // On the ground
            if (_grounded)
            {
                // Character is performing a skill
                if (Input.GetButtonDown("Fire1"))
                {
                    _currentMana -= 5;
                    _currentStamina -= 15;

                    _attack = _attack == 0 ? 1 : 0;
                    _animator.SetInteger("_attack", _attack);
                    _animator.SetFloat("_combo", _weaponCombo);
                    _weaponIdle = false;
                    Skill(0.45f);

                    _weaponCombo = _weaponCombo < _maxCombo ? _weaponCombo + 1 : 0;
                }
                // Character is moving
                else if (_horizontal != 0)
                {
                    EndCombo();
                    CallAnimation(1);
                }
                // Character is standing still
                else
                {
                    if (!_weaponIdle)
                    {
                        EndCombo();
                        CallAnimation(0);
                    }
                }
            }
            // In the air
            else
            {
                EndCombo();
                CallAnimation(3);
                _animator.SetFloat("_velocityY", _mainRB.velocity.y);
                _mainRB.AddForce(Physics.gravity * 0.1f);
            }

            
        }
    }

    private void EndCombo()
    {
        _weaponIdle = false;
        _weaponCombo = 0;
    }

    private void SetWeaponIdle ()
    {
        _weaponIdle = true;        
    }

    private void SetWeaponSheathing ()
    {
        _weaponSheathing = true;
        _weaponIdle = false;
    }

    private void FixedUpdate()
    {
        // Movement
        if (_actionCooldown <= 0)
        {
            _mainRB.velocity = new Vector3(_horizontal * (_runSpeed * _actionSpeed), _mainRB.velocity.y, 0);         
        }
        else
        {
            _mainRB.velocity = new Vector3(0, _mainRB.velocity.y, 0);
        }
    }
}
