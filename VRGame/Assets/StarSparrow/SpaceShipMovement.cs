using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    public GameObject Head;
    public GameObject Cam;
    public GameObject SpaceShip;

    float CurrRot;
    float PrevRot;
    float DeltRot;


    void Start()
    {

    }

    void Update()
    {
        Head.transform.Translate(Cam.transform.forward * Time.deltaTime * 5f);
        tilt();
    }

    void tilt()
    {
        CurrRot = Cam.transform.eulerAngles.y;
        DeltRot = CurrRot - PrevRot;
        PrevRot = CurrRot;

        if (DeltRot > 0)
        {
            SpaceShip.transform.localRotation =
                Quaternion.Lerp(
                    SpaceShip.transform.localRotation,
                    Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, -45),
                    Time.deltaTime
                );
        }
        else if (DeltRot < 0)
        {
            SpaceShip.transform.localRotation =
                Quaternion.Lerp(
                    SpaceShip.transform.localRotation,
                    Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 45),
                    Time.deltaTime
                );
        }
        else
        {
            SpaceShip.transform.localRotation =
                Quaternion.Lerp(
                    SpaceShip.transform.localRotation,
                    Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 0),
                    Time.deltaTime
                );
        }
    }

}