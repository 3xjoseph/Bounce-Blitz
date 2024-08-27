using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision : MonoBehaviour
{
    MeshRenderer mRenderer;
    int currentSceneIndex;
    [SerializeField] float delayInSeconds;

    [SerializeField] AudioClip gameOver;

    // Cache AudioSource Reference
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        switch (other.gameObject.tag)
        {
            case "Finish":
                NextLevel();
                break;
            case "Danger":
                GameOver();
                break;

        }
    }
    private void NextLevel()
    { 
      GetComponent<Movement>().enabled = false;
      Invoke("LoadNextLevel", delayInSeconds);
    }

    private void LoadNextLevel() 
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextIndex = currentSceneIndex + 1;
        if (nextIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextIndex = 0;
        }
        SceneManager.LoadScene(nextIndex); 
    }
    
    
    private void GameOver()
    {
        audioSource.PlayOneShot(gameOver);
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadLevel", delayInSeconds);
    }

    private void ReloadLevel()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex);
    }
}
