using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {

    [SerializeField] private Text timerText;
    [SerializeField] private Text footerButtonText;
    [SerializeField] private GameObject timerSettingButtons;
    [SerializeField] private GameObject finishPanel;

    public void UpdateTime(float time){
        timerText.text = string.Format("{0:00}:{1:00}", (int)(time / 60), time % 60);
    }

    public void StartTimer(){
        timerSettingButtons.SetActive(false);
        footerButtonText.text = "STOP";
    }

    public void StopTimer(){
        timerSettingButtons.SetActive(true);
        footerButtonText.text = "START";
    }

    public void FinishTimer(){
        finishPanel.SetActive(true);
    }

    public void CloseFinishPanel(){
        finishPanel.SetActive(false);
    }
}
