using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public Vector3 ads = new Vector3(1, 2 ,3);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(0, 7, -10);
        transform.RotateAround(Player.transform.position, Vector3.up, 1);
    }
}
