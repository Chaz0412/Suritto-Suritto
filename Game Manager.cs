using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator animator;
    private int leveltoLoad;

    public void FadeToLevel (int levelIndex)
    {
        leveltoLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(leveltoLoad);
    }

    public void loadNextLevel(int x)
    {
        SceneManager.LoadScene(x);
    }
}
