using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] List<GameObject> set1;
    [SerializeField] List<GameObject> set2;
    [SerializeField] List<GameObject> set3;
    [SerializeField] List<GameObject> set4;
    [SerializeField] List<GameObject> set5;
    [SerializeField] List<GameObject> set6;
    [SerializeField] List<GameObject> set7;
    [SerializeField] List<GameObject> set8;
    [SerializeField] List<GameObject> set9;
    [SerializeField] List<GameObject> set10;
    [SerializeField] List<GameObject> set11;
    [SerializeField] GameObject button;

    [SerializeField] Transform alignment;
    public void BuildingsSet1()
    {
        int count = 0;
        foreach (GameObject a in set1)
        {
            count ++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void BuildingsSet2()
    {
        int count = 0;
        foreach (GameObject a in set2)
        {
            count ++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void BuildingsSet3()
    {
        int count = 0;
        foreach (GameObject a in set3)
        {
            count ++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void BuildingsSet4()
    {
        int count = 0;
        foreach (GameObject a in set4)
        {
            count ++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void BuildingsSet5()
    {
        int count = 0;
        foreach (GameObject a in set5)
        {
            count ++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void BuildingsSet6()
    {
        int count = 0;
        foreach (GameObject a in set6)
        {
            count ++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void BuildingsSet7()
    {
        int count = 0;
        foreach (GameObject a in set7)
        {
            count ++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void BuildingsSet8()
    {
        int count = 0;
        foreach (GameObject a in set8)
        {
            count ++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void BuildingsSet9()
    {
        int count = 0;
        foreach (GameObject a in set9)
        {
            count ++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void BuildingsSet10()
    {
        int count = 0;
        foreach (GameObject a in set10)
        {
            count++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void BuildingsSet11()
    {
        int count = 0;
        foreach (GameObject a in set11)
        {
            count ++;
            GameObject g = Instantiate(button, alignment);
            g.GetComponentInChildren<Text>().text = "Building" + count.ToString();
            g.GetComponent<ButtonAction>().SetObject(a.GetComponent<Building>());
        }
    }
    public void Close()
    {
        while (alignment.childCount > 0)
            DestroyImmediate(alignment.GetChild(0).gameObject);
    }
}
