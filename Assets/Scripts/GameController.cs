using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject _enemyPanel;

    public GameObject ActivateEnemySpellPanel()
    {
        _enemyPanel.SetActive(true);
        return _enemyPanel;
    }
}
