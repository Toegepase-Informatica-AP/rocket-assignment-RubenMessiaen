using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string nextLevel;

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nextLevel);
    }

}
