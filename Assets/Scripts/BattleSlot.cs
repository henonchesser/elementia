using UnityEngine;
using System.Collections;

public class BattleSlot : MonoBehaviour {

    private bool _equiped;
    [SerializeField]
    private GameObject _equipedPrefab;

    public GameObject _equipedInstance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool IsEquiped()
    {
        return _equiped;
    }

    public void ToggleEquiped()
    {
        _equiped = !_equiped;
    }

    public void EquipSelected(Sprite icon, GameObject caller)
    {
        _equiped = true;
        _equipedInstance =  (GameObject)Instantiate (_equipedPrefab, transform.position, Quaternion.identity);
        _equipedInstance.transform.SetParent(transform);
        _equipedInstance.GetComponent<Equiped>().SetCaller(caller);
        _equipedInstance.GetComponent<Equiped>().SetSprite(icon);
    }
}
