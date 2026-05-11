using UnityEngine;
public class SlidingDoor : MonoBehaviour
{
    [Header("Door Parts")]
    public Transform leftDoor;
    public Transform rightDoor;
    [Header("Settings")]
    public float slideDistance = 2f;
    public float speed = 2f;
    Vector3 leftClosedPos;
    Vector3 rightClosedPos;
    Vector3 leftOpenPos;
    Vector3 rightOpenPos;
    bool isOpen = false;
    void Start()
    {
        leftClosedPos =
            leftDoor.localPosition;
        rightClosedPos =
            rightDoor.localPosition;
        leftOpenPos =
            leftClosedPos +
            Vector3.left * slideDistance;
        rightOpenPos =
            rightClosedPos +
            Vector3.right * slideDistance;
    }
    void Update()
    {
        if (isOpen)
        {
            leftDoor.localPosition =
                Vector3.Lerp(
                    leftDoor.localPosition,
                    leftOpenPos,
                    Time.deltaTime * speed);
            rightDoor.localPosition =
                Vector3.Lerp(
                    rightDoor.localPosition,
                    rightOpenPos,
                    Time.deltaTime * speed);
        }
        else
        {
            leftDoor.localPosition =
                Vector3.Lerp(
                    leftDoor.localPosition,
                    leftClosedPos,
                    Time.deltaTime * speed);
            rightDoor.localPosition =
                Vector3.Lerp(
                    rightDoor.localPosition,
                    rightClosedPos,
                    Time.deltaTime * speed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = false;
        }
    }
}
