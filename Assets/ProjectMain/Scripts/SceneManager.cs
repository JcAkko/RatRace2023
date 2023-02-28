using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // the financial report of the month
    [SerializeField] GameObject financialReport;

    // the newsCast of the month
    [SerializeField] GameObject newsCastBrief;


    //private bool financialReportOn = false;
    //private bool newsCastBriefOn = false;

    public void QuitGame()
    {
        Application.Quit();
    }

    private void Start()
    {
        financialReport.SetActive(false);
        newsCastBrief.SetActive(false);
    }


    public void OpenFinancialReport()
    {
        financialReport.SetActive(!financialReport.activeInHierarchy);
    }

    public void OpenNewsCastBrief()
    {
        newsCastBrief.SetActive(!newsCastBrief.activeInHierarchy);
    }



}
