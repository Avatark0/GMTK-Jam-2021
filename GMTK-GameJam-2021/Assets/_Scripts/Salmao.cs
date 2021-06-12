using UnityEngine;

public class Salmao : Gravidade
{
    protected override Vector3 gravity{
        get{
            return new Vector3(0,1,0);
        }
    }
}
