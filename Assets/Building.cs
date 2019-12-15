using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    [SerializeField] private int cost;
    [SerializeField] private string classification;
    [SerializeField] private int evolution = 0;

    private GameObject canvas;
    private Text _cost;
    private Text _classification;
    private Text _evolution;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        _cost = GameObject.Find("level").GetComponent<Text>();
        _classification = GameObject.Find("classification").GetComponent<Text>();
        _evolution = GameObject.Find("cost").GetComponent<Text>();
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            ShowMenu();
    }
    private void ShowMenu()
    {
        canvas.SetActive(true);
        _cost.text = cost.ToString();
        _classification.text = classification;
        _evolution.text = evolution.ToString();
    }
}
