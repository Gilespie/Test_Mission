using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public void ChangeLevel(int levelindex)
    {
        SceneManager.LoadScene(levelindex);
    }
}
