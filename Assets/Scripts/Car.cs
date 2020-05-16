using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Car : MonoBehaviour {
    private CarController carController;
    [SerializeField] private Image speedImage;
    [SerializeField] private Text speedText;
    [SerializeField] private float percentage = 22f;
    [SerializeField] private GameObject mainController;
    private MainController mc;

    void Start() {
        carController = this.GetComponent<CarController>();
        mc = mainController.GetComponent<MainController>();
    }

    void Update() {
        float ratio = Mathf.InverseLerp(0f, 1f, Mathf.Abs(carController.CurrentSpeed) / carController.MaxSpeed);
        speedImage.fillAmount = Mathf.Lerp(percentage / carController.MaxSpeed, (carController.MaxSpeed - percentage) / carController.MaxSpeed, ratio);
        speedText.text = Mathf.Abs(carController.CurrentSpeed).ToString("000") + "km/h";
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "GoalWall"){
            mc.finish(true);
        } else if (collision.gameObject.tag == "Wall"){
            mc.finish(false);
        }
    }
}
