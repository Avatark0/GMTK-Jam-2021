using UnityEngine;

public class GravTiffany : _Gravidade
{
    protected override Vector3 gravity{
        get{
            return new Vector3(-1,0,0);
        }
    }
}
