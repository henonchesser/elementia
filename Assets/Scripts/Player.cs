using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    [SerializeField]
    private bool _isWalking;

    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private float _speed = 2f;
    private Transform _transform;
    private Vector3 _target;

	// Use this for initialization
	void Start () {
        _transform = transform;
        _target = _transform.position;
	}

    public void WalkToNextChunk()
    {
        if (!_isWalking) {
            //set target 20 moves ahead
            _target.x += 20;
        }
    }
	
	// Update is called once per frame
	void Update () {
        HandleWalking();
        
	}

    private void HandleWalking()
    {
        
        if (_transform.position != _target)
        {
            _isWalking = true;
            _animator.SetBool("isWalking", true);
            float step = _speed * Time.deltaTime;
            _transform.position = Vector3.MoveTowards(_transform.position, _target, step);
        }
        else
        {
            _isWalking = false;
            _animator.SetBool("isWalking", false);
        }

    }
}
