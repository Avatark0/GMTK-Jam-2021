using UnityEngine;

public abstract class Gravidade : MonoBehaviour
{
    protected double time = 0;
    protected double timeStep = 0.6;
    protected float moveStep = 0.25f;
    
    protected abstract Vector3 gravity {get;}

    private void Update() {
        if(Time.time - time >= timeStep){
            //Debug.Log("timeStep "+name);
            transform.Translate(gravity*moveStep);
            time+=timeStep;
        }
    }
}
