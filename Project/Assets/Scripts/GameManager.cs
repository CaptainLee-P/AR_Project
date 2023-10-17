using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    public int randomNumber;
    private void Start()
    {
        randomNumber = Random.Range(0, 3);
    }

    public void GoHome()
    {
        SceneManager.LoadScene("MainScene");
    }
}
