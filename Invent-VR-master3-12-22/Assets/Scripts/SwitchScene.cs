using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour
{
 
public class Control : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("InventVR2_hands");
    }
}
}
