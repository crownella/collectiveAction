using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject eyePodPrefab;
    public GameObject spawnPoint;
    GameObject pip = null;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        if (pip == null)
        {
            pip = Instantiate(eyePodPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
        }
    }
}
