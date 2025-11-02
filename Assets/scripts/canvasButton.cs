using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasButton : MonoBehaviour{

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
