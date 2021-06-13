using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadManha()
    {
        SceneManager.LoadScene("1-Manha");
    }

    public void LoadTarde()
    {
        SceneManager.LoadScene("2-Tarde");
    }

    public void LoadNoite()
    {
        SceneManager.LoadScene("3-Noite");
    }

    public void LoadMadru()
    {
        SceneManager.LoadScene("4-Madru");
    }
}
