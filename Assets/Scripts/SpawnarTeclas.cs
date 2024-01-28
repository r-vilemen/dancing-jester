using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnarTeclas : MonoBehaviour
{
    public GameObject spawnLeft;
    public GameObject spawnUp;
    public GameObject spawnRight;
    public GameObject spawnDown;

    public GameObject leftArrow;
    public GameObject upArrow;
    public GameObject rightArrow;
    public GameObject downArrow;
    public GameObject wrongleftArrow;
    public GameObject wrongupArrow;
    public GameObject wrongrightArrow;
    public GameObject wrongdownArrow;

    public int spawnNumber;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bpmSpawn());

    }

    // Update is called once per frame
    void Update()
    {
        if(spawnNumber >= 1 && spawnNumber <=20)
        {
            Instantiate(leftArrow, spawnLeft.transform.position, Quaternion.identity);
            spawnNumber = 0;
        }
        if (spawnNumber >= 21 && spawnNumber <=42)
        {
            Instantiate(upArrow, spawnUp.transform.position, Quaternion.identity);
            spawnNumber = 0;
        }
        if (spawnNumber >= 43 && spawnNumber <=64)
        {
            Instantiate(rightArrow, spawnRight.transform.position, Quaternion.identity);
            spawnNumber = 0;
        }
        if (spawnNumber >= 65 && spawnNumber <= 86)
        {
            Instantiate(downArrow, spawnDown.transform.position, Quaternion.identity);
            spawnNumber = 0;
        }
        if (spawnNumber >= 87 && spawnNumber <= 90)
        {
            Instantiate(wrongleftArrow, spawnLeft.transform.position, Quaternion.identity);
            spawnNumber = 0;
        }
        if (spawnNumber >= 91 && spawnNumber <= 94)
        {
            Instantiate(wrongupArrow, spawnUp.transform.position, Quaternion.identity);
            spawnNumber = 0;
        }
        if (spawnNumber >= 95 && spawnNumber <= 98)
        {
            Instantiate(wrongrightArrow, spawnRight.transform.position, Quaternion.identity);
            spawnNumber = 0;
        }
        if (spawnNumber >= 98 && spawnNumber <= 102)
        {
            Instantiate(wrongdownArrow, spawnDown.transform.position, Quaternion.identity);
            spawnNumber = 0;
        }
    }

    IEnumerator bpmSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            spawnNumber = Random.Range(1, 101);
            //Debug.Log(spawnNumber);
        }

    }
}
