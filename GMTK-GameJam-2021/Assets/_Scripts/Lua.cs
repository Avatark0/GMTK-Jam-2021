using UnityEngine;

public class Lua : Gravidade
{
    protected override Vector3 gravity{
        get{
            return new Vector3(1,0,0);
        }
    }
}
