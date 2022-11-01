using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour
{
    public GameObject[] pickupPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pickupPrefabs[0], transform.position, transform.rotation);
    }
}
