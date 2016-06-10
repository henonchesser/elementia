using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

    [SerializeField]
    private float _speed = 2f;
    [SerializeField]
    private Transform _transform;
    [SerializeField]
    private Vector3 _target;

    public GameObject _master;

    private bool _isWalking;
    private bool _battleReady;
    private bool _hasPanel;

    // Use this for initialization
    void Start () {
        _transform = transform;
        _target = _transform.position;
        _target.x -= 7;
        _battleReady = true;
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
            float step = _speed * Time.deltaTime;
            _transform.position = Vector3.MoveTowards(_transform.position, _target, step);
        }
        else
        {
            _isWalking = false;
            if (_battleReady && !_hasPanel)
            {
                _master.GetComponent<MonsterMaster>().ReadyBattle(gameObject);
                _hasPanel = true;
            }
        }
    }

}
