using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] float xValue=0;
    // [SerializeField] float yValue=0;
    // [SerializeField] float zValue=0;
    [SerializeField] float MoveSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}
