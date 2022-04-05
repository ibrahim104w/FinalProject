using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class storyline : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("outside", LoadSceneMode.Single);
    }

}
