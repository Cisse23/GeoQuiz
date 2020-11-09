using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Load50States()
    {
        SceneManager.LoadScene("50 States");
    }

    public void Quit()
    {
        {
            Application.Quit();
        }
    }

}
