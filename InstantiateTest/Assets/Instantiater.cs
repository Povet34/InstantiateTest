using UnityEngine;

public class Instantiater : MonoBehaviour
{
    public static int Order = 0;

    [SerializeField] GameObject InstanceTargetGo;
    [SerializeField] InstanceTarget1 target1;
    [SerializeField] InstanceTarget2 target2;

    [SerializeField] GameObject Reference;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            InstantiateGo();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            InstantiateTargaet1();
        }
    }

    private void InstantiateGo()
    {
        Order = 0;

        GameObject go = Instantiate(InstanceTargetGo);
        InstanceTarget1 target1 = go.GetComponent<InstanceTarget1>();
        InstanceTarget2 target2 = go.GetComponent<InstanceTarget2>();

        target1.Number = 1;
        target2.Number = 2;

        target1.Reference = Reference;
        target2.Reference = Reference;

        target1.Init();
        target2.Init();
    }

    private void InstantiateTargaet1()
    {
        Order = 0;

        InstanceTarget1 target1 = Instantiate(this.target1);
        InstanceTarget2 target2 = target1.GetComponent<InstanceTarget2>();

        target1.Number = 1;
        target2.Number = 2;

        target1.Reference = Reference;
        target2.Reference = Reference;

        target1.Init();
        target2.Init();
    }

    public static int GetOrder()
    {
        return Order++;
    }
}
