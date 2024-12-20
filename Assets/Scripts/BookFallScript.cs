using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookFallScript : MonoBehaviour
{
    [SerializeField] private Transform book;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AllowBookFall()
    {
        // remove the constraint on the book on the x-axis rotation
        book.GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezeRotationX;
    }
}
