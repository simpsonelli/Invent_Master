using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDrop : MonoBehaviour
{
    [SerializeField]
    private GameObject logoCube;

    [SerializeField]
    private GameObject logoCube1;

    public float speed;

    public void StartScript()
    {
        StartCoroutine(MoveAtoB(logoCube, logoCube1, speed));
    }

    IEnumerator MoveAtoB(GameObject gameObjectA, GameObject gameObjectB, float speedTranslation)
    {
        while (gameObjectA.transform.position != gameObjectB.transform.position)
        {
            gameObjectA.transform.position = Vector3.MoveTowards(gameObjectA.transform.position, gameObjectB.transform.position, speedTranslation * Time.deltaTime);
            yield return null;
        }
    }

}
