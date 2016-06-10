using UnityEngine;
using UnityEngine.UI;

public class SpellButton : MonoBehaviour {

    [SerializeField]
    private bool _isRune;
    [SerializeField]
    private Sprite _inactiveSprite;
    [SerializeField]
    private Sprite _activeSprite;
    [SerializeField]
    private BattlePanel _playerPanel;

    private Image _myImage;

    private bool _active;

    // Use this for initialization
    void Start () {
	    
       
        
	}
	
	// Update is called once per frame
	void Update () {

      
        if (_active)
        {
            SetSprite(_activeSprite);
        }
        else
        {
            SetSprite(_inactiveSprite);
        }
       
      
       
	}

    private void SetSprite(Sprite image)
    {
        var _myImage = this.GetComponent<Image>();
        _myImage.sprite = image;
    }

    public void ToggleActive()
    {
        _active = !_active;
    }

    public void ActivateSpell()
    {
        //if i'm not active
        if (!_active)
        {
            //check for open slots in the battle panel
            foreach(Transform slot in _playerPanel.transform)
            {
                var thisSlot = slot.gameObject.GetComponent<BattleSlot>();
               

                //if this slots empty put me there
                if (thisSlot.IsEquiped() == false)
                {
                    GetComponent<AudioSource>().Play();
                    thisSlot.EquipSelected(_inactiveSprite, gameObject);
                    ToggleActive();
                    return;
                }
            }
        }

    }
}
