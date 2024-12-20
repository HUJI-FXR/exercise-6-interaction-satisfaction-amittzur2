using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BearScript : MonoBehaviour
{
    [SerializeField] private Transform ground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the bear's y position is less than -10, call DestroyBear
        if (transform.position.y < -10)
        {
            DestroyBear();
        }

    }
    public void DestroyBear()
    {
        // destroy the bear and set the teleportation area component of the ground to active
        Destroy(gameObject);
        ground.GetComponent<TeleportationArea>().enabled = true;
    }
}
