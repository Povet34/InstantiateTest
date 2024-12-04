using UnityEngine;

public class InstanceTarget2 : MonoBehaviour
{
    public int Number = 0;
    public GameObject Reference;

    void Awake()
    {
        Debug.Log($"Awake InstanceTarget2 [{Instantiater.GetOrder()}] [Reference {Reference}] [Number {Number}]");
    }

    void Start()
    {
        Debug.Log($"Start InstanceTarget2 [{Instantiater.GetOrder()}] [Reference {Reference}] [Number {Number}]");
    }

    public void Init()
    {
        Debug.Log($"Init InstanceTarget2 [{Instantiater.GetOrder()}] [Reference {Reference}] [Number {Number}]");
    }
}
