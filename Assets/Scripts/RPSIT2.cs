using UnityEngine;

public class RPSIT2 : MonoBehaviour
{
    [SerializeField] private GameObject[] rpcOptions;
    [SerializeField] private GameObject targetObject;

    public void optionChoosen(int Index)
    {
        Vector3 position = targetObject.transform.position;
        Destroy(targetObject);
        Instantiate(rpcOptions[Index], position, Quaternion.identity);
    }
}
