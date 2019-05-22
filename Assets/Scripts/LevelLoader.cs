using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int waitTime = 6;
    int currentScenceIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentScenceIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentScenceIndex == 0) {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime() {
        yield return new WaitForSeconds(waitTime);
        LoadNextScene();
    }

    public void LoadNextScene() {
        SceneManager.LoadScene(currentScenceIndex + 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
