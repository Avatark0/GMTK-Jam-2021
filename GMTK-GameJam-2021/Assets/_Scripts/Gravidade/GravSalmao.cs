using UnityEngine;

public class GravSalmao : _Gravidade
{
    protected override Vector3 gravity{
        get{
            return new Vector3(0,1,0);
        }
    }
}
