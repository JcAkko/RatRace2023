using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class UIController : MonoBehaviour
{
    // reference to the flowchart obj
    public Flowchart flowChart;

    // refer to the financial report button
    [SerializeField] GameObject financialReportButton;

    // refer to the news cast review
    [SerializeField] GameObject newsCastButton;

    // bool to check if both buttons are reviewed
    private bool isFRReviewed = false;
    private bool isNewsReviewed = false;



    private void Start()
    {
        // hide both button
        financialReportButton.SetActive(isFRReviewed);
        newsCastButton.SetActive(isNewsReviewed);
    }


    private void Update()
    {
        // check for news reveal
        ShowButtons();
        
    }


    private void ShowButtons()
    {
        newsCastButton.SetActive(flowChart.GetBooleanVariable("newsRevealed"));
        financialReportButton.SetActive(flowChart.GetBooleanVariable("FRRevealed"));
    }



}
