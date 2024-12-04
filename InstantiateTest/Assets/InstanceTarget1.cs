using UnityEngine;

public class InstanceTarget1 : MonoBehaviour
{
    public int Number = 0;
    public GameObject Reference;

    void Awake()
    {
        Debug.Log($"Awake InstanceTarget1 [{Instantiater.GetOrder()}] [Reference {Reference}] [Number {Number}]");
    }

    void Start()
    {
        Debug.Log($"Start InstanceTarget1 [{Instantiater.GetOrder()}] [Reference {Reference}] [Number {Number}]");
    }

    public void Init()
    {
        Debug.Log($"Init InstanceTarget1 [{Instantiater.GetOrder()}] [Reference {Reference}] [Number {Number}]");
    }
}
