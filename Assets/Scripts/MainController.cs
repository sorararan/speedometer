using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class MainController : MonoBehaviour {
    private TextController textController;
    [SerializeField] private Car car;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float minSpeed;
    [SerializeField] Text timeText;
    private float count;
    private float startCount;
    private bool is_finished;

    void Start() {
        WallGenerator.execute();
        textController = GetComponent<TextController>();
        count = 0f;
        startCount = 0f;
        is_finished = false;
    }

    void FixedUpdate() {
        if(!is_finished){
            if (startCount >= 3.0f){
                float speed = Mathf.Abs(car.GetComponent<CarController>().CurrentSpeed);
                if (speed < minSpeed || speed > maxSpeed) {
                    count += Time.deltaTime;
                    timeText.text = count.ToString("f1") + "秒";
                    if(count >= 3.0f){
                        finish(false);
                    }
                } else {
                    count = 0f;
                    timeText.text = count.ToString("f1") + "秒";
                }
            } else {
                startCount += Time.deltaTime;
                timeText.text = (3.0f - startCount).ToString("f1") + "秒";
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene ("Scenes/Title");
            return;
        }
    }

    public void finish(bool is_clear) {
        textController.setEndText(is_clear);
        is_finished = true;
    }
}
