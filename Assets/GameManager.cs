using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;

    public int platformCount = 100;

    void Start()
    {
        Vector3 spwanPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spwanPosition.y += Random.Range(.1f, 3f);
            spwanPosition.x = Random.Range(-.5f, 5f);
            Instantiate(platformPrefab, spwanPosition, Quaternion.identity);
        }
    }
}
