using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private GameObject tabuleiro;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
            tabuleiro.GetComponent<Tabuleiro>().RotateLeft();
        else if(Input.GetKeyDown(KeyCode.RightArrow))
            tabuleiro.GetComponent<Tabuleiro>().RotateRight();
    }
}
