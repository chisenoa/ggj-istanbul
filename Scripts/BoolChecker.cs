using UnityEngine;
using UnityEngine.SceneManagement;

public class BoolChecker : MonoBehaviour
{
    public bool isDoneLeft;
    public bool isDoneRight;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (isDoneLeft == true && isDoneRight == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void ActiveLeftBool()
    {
        isDoneLeft = true;
    }
    public void ActiveRightBool()
    {
        isDoneRight = true;
    }
    public void Button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
