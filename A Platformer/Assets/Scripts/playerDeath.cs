using UnityEngine;

public class playerDeath : MonoBehaviour {

    public GameObject player;
    public Transform startingPos;

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "Ground1" || other.gameObject.tag == "Ground2") {
            playerDies();
        }
        
    }

    public void playerDies() {

        player.transform.position = startingPos.position;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        groundChanges.currentGround = 1;
        groundChanges.groundChanging();

    }

}
