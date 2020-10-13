using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCoin : MonoBehaviour
{
    public GameObject prefab;
    public float minX = 450f;
    public float maxX = 500f;
    public float minZ = 350f;
    public float maxZ = 370f;

    public GameObject terrain;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < GameVariables.nbCoins; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(minX, maxX), 0, Random.Range(minZ, maxZ));
            randomPos.y = terrain.GetComponent<Terrain>().SampleHeight(randomPos) + 1.0f;
            Instantiate(prefab, randomPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
