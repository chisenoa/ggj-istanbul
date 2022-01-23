using UnityEngine;

public class FoodManager : MonoBehaviour
{
    BoolChecker boolChecker;
    void Start()
    {
        boolChecker = FindObjectOfType<BoolChecker>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "karakter")
        {
            boolChecker.ActiveLeftBool();
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "karakter2")
        {
            boolChecker.ActiveRightBool();
            gameObject.SetActive(false);
        }
    }
}
