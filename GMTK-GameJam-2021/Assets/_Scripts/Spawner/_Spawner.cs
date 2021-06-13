using UnityEngine;

public class _Spawner : MonoBehaviour
{
    [SerializeField] protected GameObject bloco;

    protected GameObject parentBlocos;

    protected double time;
    protected double timeStep = 6;

    private void Start(){
        parentBlocos = GameObject.FindWithTag("Blocos");
        time = Time.time;
    }

    private void Update() {
        if(Time.time - time >= timeStep){
            Instantiate(bloco,parentBlocos.transform);

            time+=timeStep;
            //Debug.Log("time = "+time);
        }
    }
}
