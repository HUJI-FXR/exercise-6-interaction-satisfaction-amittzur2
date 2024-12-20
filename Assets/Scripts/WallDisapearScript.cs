using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDisapearScript : MonoBehaviour
{
    [SerializeField] bool isLeftBallIn = false;
    [SerializeField] bool isRightBallIn = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddBallIn(string ballName)
    {
        if (ballName == "LeftBall")
        {
            isLeftBallIn = true;
        }
        else if (ballName == "RightBall")
        {
            isRightBallIn = true;
        }
        if (isLeftBallIn && isRightBallIn)
        {
            Destroy(gameObject);
        }
    }
    public void RemoveBallIn(string ballName)
    {
        if (ballName == "LeftBall")
        {
            isLeftBallIn = false;
        }
        else if (ballName == "RightBall")
        {
            isRightBallIn = false;
        }
    }

}
