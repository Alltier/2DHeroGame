using UnityEngine;
using UnityEngine.SceneManagement;
public class Finnish : MonoBehaviour
{

    private bool levelComplated = false;

    [SerializeField] private GameObject finishCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !levelComplated)
        {
            levelComplated = true;

            finishCamera.SetActive(true);

            Invoke(nameof(ComplateLevel), 2f);
        }
    }


    private void ComplateLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
