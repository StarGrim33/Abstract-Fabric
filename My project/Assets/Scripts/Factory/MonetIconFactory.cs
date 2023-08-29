using UnityEngine;

public class MonetIconFactory : IconFactory
{
    public override Sprite Get(IconForm iconForms)
    {
        return Resources.Load<Sprite>(Constants.MonetIcon);
    }
}
