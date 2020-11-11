using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;// this will be shown in the inspector
    [SerializeField]
    private float _horizontalInput;
    [SerializeField]
    private float _verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(_horizontalInput, 0, 0) * _speed * Time.deltaTime);

        _verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, _verticalInput, 0) * _speed * Time.deltaTime);
    }
}
