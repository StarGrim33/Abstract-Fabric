using UnityEngine;

public class ThunderIconFactory : IconFactory
{
    public override Sprite Get(IconForm iconForms)
    {
        return Resources.Load<Sprite>(Constants.ThunderIcon);
    }
}
