using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    void Start() {
        thingToFollow = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(thingToFollow);
    }
    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);

    }
}
