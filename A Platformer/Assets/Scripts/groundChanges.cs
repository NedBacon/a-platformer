using UnityEngine;

public class groundChanges : MonoBehaviour {

    public int currentGround;
    public GameObject[] ground1;
    public GameObject[] ground2;

    private void Start() {
        
        currentGround = 1;
        groundChanging();

    }

    private void Update() {

        if(Input.GetKey("w") && playerMovement.playerGrounded) {
            groundChanging();
        }
        
    }

    private void groundChanging() {

        if(currentGround == 1) {
            currentGround = 2;
            foreach(GameObject obj in ground1) {
                obj.SetActive(false);
            }
            foreach(GameObject obj in ground2) {
                obj.SetActive(true);
            }
        } else {
            currentGround = 1;
            foreach(GameObject obj in ground1) {
                obj.SetActive(true);
            }
            foreach(GameObject obj in ground2) {
                obj.SetActive(false);
            }
        }

    }

}
