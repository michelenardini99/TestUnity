using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    static float DEFAUT_VELOCITY = 5; 

    [SerializeField]
    float speed = DEFAUT_VELOCITY;    //Velocità di movimento

    // Update is called once per frame
    void Update()
    {
        //se premo il tasto
        //muovo l'ggetto sull'asse corrispondente al lato
        //"Horizontal"

        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(0, 0, 0);

        if (Input.GetAxis("Horizontal") != 0)
        {
            direction.x = horizontalMovement;
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            direction.y = verticalMovement;
        }
        transform.Translate(direction * (speed * Time.deltaTime));
    }
}
