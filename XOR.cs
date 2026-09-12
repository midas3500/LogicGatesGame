using UnityEngine;

public class XOR : MonoBehaviour
{
    [SerializeField] private Energy _isPassing1;
    [SerializeField] private Energy _isPassing2;

    public bool exitEnergy;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        XORLogic();
    }

    void XORLogic()
    {
        if (_isPassing1._bit != null && _isPassing2._bit != null)
        {
            if (_isPassing1._bit == _isPassing2._bit)
            {
                exitEnergy = false;
            }
            else
            {
                exitEnergy = true;
            }
        }
    }
}
