using UnityEngine;

public class playerMovement : MonoBehaviour {

    public GameObject player;
    public GameObject cam;
    public float playerSpeed;
    public int playerJumpHeight;
    public RaycastHit2D RH;
    static public bool playerGrounded;

    private void Update() {

        if(Input.GetKey("w") && playerGrounded) {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity[0], playerJumpHeight);
            groundChanges.groundChanging();
        }

        RH = Physics2D.BoxCast(new Vector2(player.transform.position[0], player.transform.position[1] - 0.8f), new Vector2(0.8f, 0.05f), 0, Vector2.down, .1f);
        if(RH.transform != player.transform && player.GetComponent<Rigidbody2D>().velocity[1] == 0 && RH.transform != null) {
            playerGrounded = true;
        } else {
            playerGrounded = false;
        }

        // cam.transform.position = new Vector3(player.transform.position[0], player.transform.position[1], -10);

    }

    private void FixedUpdate() {
        
        if(Input.GetKey("a")) {
            player.transform.position = new Vector2(player.transform.position[0] - playerSpeed * Time.fixedDeltaTime, player.transform.position[1]);
        }
        if(Input.GetKey("d")) {
            player.transform.position = new Vector2(player.transform.position[0] + playerSpeed * Time.fixedDeltaTime, player.transform.position[1]);
        }

        cam.transform.position = Vector2.Lerp(cam.transform.position, player.transform.position, 1.5f * Time.fixedDeltaTime);
        cam.transform.position = new Vector3(cam.transform.position[0], cam.transform.position[1], -10);

    }

}
