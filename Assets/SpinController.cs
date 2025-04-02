using UnityEngine;

public class SpinController : MonoBehaviour
{
    [SerializeField] private float spinSpeed = 0.5f;

    private int spinRotation;

    private void Start()
    {
        spinRotation = Random.Range(0, 2) == 0 ? -1 : 1;
    }
    void Update()
    {
        float rotationThisFrame = spinRotation * spinSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.Euler(0, 0, rotationThisFrame);
    }
}
