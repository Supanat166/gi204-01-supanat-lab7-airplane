using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float enginePower = 20f;
    [SerializeField] private float liftBooster = 0.5f;
    [SerializeField] private float drag = 0.001f;
    [SerializeField] private float angularDrag = 0.001f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
