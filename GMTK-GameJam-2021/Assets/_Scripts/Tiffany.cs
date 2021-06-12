using UnityEngine;

public class Tiffany : Gravidade
{
    protected override Vector3 gravity{
        get{
            return new Vector3(-1,0,0);
        }
    }
}
