using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    [SerializeField] private string myTag = default;
    void Awake(){
        GameObject[] objs = GameObject.FindGameObjectsWithTag(myTag);

        if (objs.Length > 1){
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
