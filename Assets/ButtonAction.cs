using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    Building build;
    public void SetObject(Building a)
    {
        build = a;
    }

    public void Clicked()
    {
        build.ShowMenu();
    }
}
