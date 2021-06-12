using UnityEngine;

public class Sol : Gravidade
{
    protected override Vector3 gravity{
        get{
            return new Vector3(0,-1,0);
        }
    }
}
