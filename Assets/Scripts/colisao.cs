using UnityEngine;

public class Colisao : MonoBehaviour
{
    public GameObject leftArrow;
    public GameObject upArrow;
    public GameObject rightArrow;
    public GameObject downArrow;

    bool bpm = true;
    public float lefty = 0;
    public float upy = 0;
    public float righty = 0;
    public float downy = 0;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            lefty = 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            upy = 1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            righty = 1;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            downy = 1;
        }
    }
    void FixedUpdate()
    {
        if (!bpm && Time.time >= 1)
        {
            bpm = true;
        }

        if (bpm && Time.time >= 1)
        {
            bpm = false;
        }

    }

}