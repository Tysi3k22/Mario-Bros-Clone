using UnityEngine;

public class endGateScript : MonoBehaviour
{
    [SerializeField] private GameObject endGate; 
    [SerializeField] private GameObject player;
    [SerializeField] private Camera cam;
    private moveingScript moveingScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        moveingScript = GameObject.FindGameObjectWithTag("Player").GetComponent<moveingScript>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveingScript.isMovingAnable = false;
        endAnim();
    }

    private void endAnim()
    {
        player.transform.position = new Vector3(player.transform.position.x + 0.7f, player.transform.position.y);
        cam.transform.position = new Vector3(player.transform.position.x + 2f, cam.transform.position.y, player.transform.position.z - 10);
    }
}
