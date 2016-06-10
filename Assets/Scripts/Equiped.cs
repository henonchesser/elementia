using UnityEngine;
using UnityEngine.UI;

public class Equiped : MonoBehaviour {

    [SerializeField]
    private Sprite _inactiveSprite;

    private GameObject _callerObject;

    private Image _myImage;


    public void SetSprite(Sprite image)
    {
        _inactiveSprite = image;
        var _myImage = this.GetComponent<Image>();
        _myImage.sprite = image;
    }

    public void SetCaller(GameObject caller)
    {
        _callerObject = caller;
    }

    public void CancelSpell()
    {
        _callerObject.GetComponent<SpellButton>().ToggleActive();
        SendMessageUpwards("ToggleEquiped");
        Destroy(gameObject);
    }
}
