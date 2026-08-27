using UnityEngine;

public class RPSIT2 : MonoBehaviour
{
    [SerializeField] private GameObject[] rpcOptions;
    [SerializeField] private GameObject targetObject;
    [SerializeField] private GameObject instantitatedObject;
    [SerializeField] private GameObject targetParent;
    public void optionChoosen(int Index)
    {
        Vector3 position = targetObject.transform.position;
        if (instantitatedObject != null)
        {
            Destroy(instantitatedObject);
            instantitatedObject = Instantiate(rpcOptions[Index], position, Quaternion.identity, targetParent.transform);
        }
        else if (instantitatedObject == null)
        {
            instantitatedObject = Instantiate(rpcOptions[Index], position, Quaternion.identity, targetParent.transform);
        }
    }
}
