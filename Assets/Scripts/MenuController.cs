using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void StartExhibition()
    {
        SceneManager.LoadScene("Scene2"); // Ganti dengan nama scene 2 nanti
        Debug.Log("Start Exhibition");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
