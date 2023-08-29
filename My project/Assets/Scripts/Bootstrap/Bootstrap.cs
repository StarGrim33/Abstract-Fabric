using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private IconForm _icon;
    [SerializeField] private List<Image> _images;

    private IconFactory _currentFactory;

    [ContextMenu("BuildMaze")]
    public void BuilIcon()
    {

        switch (_icon)
        {
            case IconForm.Monet:
                _currentFactory = new MonetIconFactory();
                UpdateIcons();
                break;

            case IconForm.Thunder:
                _currentFactory = new ThunderIconFactory();
                UpdateIcons();
                break;

            default:
                _currentFactory = new MonetIconFactory();
                UpdateIcons();
                break;
        }
    }

    private void UpdateIcons()
    {
        foreach (var item in _images)
            item.sprite = _currentFactory.Get(_icon);
    }
}
