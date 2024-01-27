using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLefty : MonoBehaviour
{
    public Vector3 NewPosition;
    public Colisao colisao_;

    void Start()
    {

    }

    void Update()
    {
        if (colisao_.lefty == 1)
        {

            Instantiate(colisao_.leftArrow, transform.position, Quaternion.identity);
            colisao_.lefty = 0;
        }
        if (colisao_.upy == 1)
        {
            Instantiate(colisao_.upArrow, NewPosition = new Vector3(transform.position.x + 1, transform.position.y, 0.0f), Quaternion.identity);
            colisao_.upy = 0;
        }
        if (colisao_.righty == 1)
        {
            Instantiate(colisao_.rightArrow, NewPosition = new Vector3(transform.position.x + 2, transform.position.y, 0.0f), Quaternion.identity);
            colisao_.righty = 0;
        }
        if (colisao_.downy == 1)
        {
            Instantiate(colisao_.downArrow, NewPosition = new Vector3(transform.position.x + 3, transform.position.y, 0.0f), Quaternion.identity);
            colisao_.downy = 0;
        }
        //-----------------------------------------
        if (colisao_.lefty == -1)
        {

            Instantiate(colisao_.wrongleftArrow, transform.position, Quaternion.identity);
            colisao_.lefty = 0;
        }
        if (colisao_.upy == -1)
        {
            Instantiate(colisao_.wrongupArrow, NewPosition = new Vector3(transform.position.x + 1, transform.position.y, 0.0f), Quaternion.identity);
            colisao_.upy = 0;
        }
        if (colisao_.righty == -1)
        {
            Instantiate(colisao_.wrongrightArrow, NewPosition = new Vector3(transform.position.x + 2, transform.position.y, 0.0f), Quaternion.identity);
            colisao_.righty = 0;
        }
        if (colisao_.downy == -1)
        {
            Instantiate(colisao_.wrongdownArrow, NewPosition = new Vector3(transform.position.x + 3, transform.position.y, 0.0f), Quaternion.identity);
            colisao_.downy = 0;
        }
    }
}
