using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    [SerializeField] private int cost;
    [SerializeField] private string classification;
    [SerializeField] private int evolution = 0;

    [SerializeField] private GameObject canvas;
    [SerializeField] private Text _cost;
    [SerializeField] private Text _classification;
    [SerializeField] private Text _evolution;
    
    public void ShowMenu()
    {
        canvas.SetActive(true);
        _cost.text = cost.ToString();
        _classification.text = classification;
        _evolution.text = evolution.ToString();
    }
}
