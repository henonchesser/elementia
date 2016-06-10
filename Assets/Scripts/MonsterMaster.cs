using UnityEngine;
using System.Collections;

public class MonsterMaster : MonoBehaviour {

    [SerializeField]
    private Player _player;

    [SerializeField]
    private GameObject[] _monstersArray;

    [SerializeField]
    private GameObject _spellPanel;

    [SerializeField]
    private GameObject _gameController;

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(_player.transform.position.x + 15f, 0f, 0f);
	}

    public void SpawnMonster()
    {
        var randomMonsterIndex = Random.Range(0, _monstersArray.Length);
        var thisMonster = (GameObject)Instantiate(_monstersArray[randomMonsterIndex], transform.position, Quaternion.identity);
        thisMonster.transform.parent = transform;
        thisMonster.GetComponent<Monster>()._master = gameObject;
    }

    public void ReadyBattle(GameObject monster)
    {
        var gameController = _gameController.GetComponent<GameController>();
        var enemySpellPanel = gameController.ActivateEnemySpellPanel();
      
    }
}
