using UnityEngine;

public class GravSol : _Gravidade
{
    protected override Vector3 gravity{
        get{
            return new Vector3(0,-1,0);
        }
    }
}
