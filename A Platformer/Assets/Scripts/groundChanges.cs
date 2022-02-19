using UnityEngine;

public class groundChanges : MonoBehaviour {

    static public int currentGround;
    static public GameObject ground1;
    static public GameObject ground2;

    // static public GameObject[] ground1;
    // static public GameObject[] ground2;

    private void Start() {

        ground1 = GameObject.Find("Ground1");
        ground2 = GameObject.Find("Ground2");
        currentGround = 1;
        groundChanging();

        // ground1 = GameObject.FindGameObjectsWithTag("Ground1");
        // ground2 = GameObject.FindGameObjectsWithTag("Ground2");

    }

    static public void groundChanging() {

        if(currentGround == 1) {
            currentGround = 2;
            ground1.SetActive(false);
            ground2.SetActive(true);
        } else {
            currentGround = 1;
            ground1.SetActive(true);
            ground2.SetActive(false);
        }

    }

    // static public void groundChanging() {

    //     if(currentGround == 2) {
    //         currentGround = 2;
    //         foreach(GameObject obj in ground1) {
    //             obj.SetActive(false);
    //         }
    //         foreach(GameObject obj in ground2) {
    //             obj.SetActive(true);
    //         }
    //     } else {
    //         currentGround = 1;
    //         foreach(GameObject obj in ground1) {
    //             obj.SetActive(true);
    //         }
    //         foreach(GameObject obj in ground2) {
    //             obj.SetActive(false);
    //         }
    //     }

    // }

}
