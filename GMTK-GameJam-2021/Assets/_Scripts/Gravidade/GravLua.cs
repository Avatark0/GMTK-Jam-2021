using UnityEngine;

public class GravLua : _Gravidade
{
    protected override Vector3 gravity{
        get{
            return new Vector3(1,0,0);
        }
    }
}
